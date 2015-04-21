using RoadRingSim;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core
{

    public delegate void EventCarDestroyHandler(Car Model);
    public delegate void EventCarMoveHandler(Car Model, Cell CellFrom, Cell CellTo);


	public class Car
	{
		/// <summary>
		/// маршрут движения машины
		/// </summary>
		public Routes RouteTo;

		public Routes RouteFrom;

		public Cell Location;

		public CarStates GoalState;

		/// <summary>
		/// цвет машины
		/// </summary>
		public Color ColorCar;

		/// <summary>
		/// желаемая линия кольца кольца исходя из RouteFrom и RouteTo
		/// </summary>
		public int NeedRingLineNumber {
            get {
                return (int)Math.Abs((int)RouteFrom - (int)RouteTo);
            }
        }

		public event EventCarDestroyHandler OnCarDestroy;

        public event EventCarMoveHandler OnCarMove;

		public Environment Environment;

        private static Random _rand = new Random();
		/// <summary>
		/// создается новая машина произвольного цвета. Ее состояние - ожидание въезда
		/// направление RouteTo задается произвольно
		/// 
		/// </summary>
        public Car(Cell Location)
        {
            RouteTo = (Routes)(_rand.Next(1, 4));
            RouteFrom = Location.Route;
            this.Location = Location;

            GoalState = CarStates.MoveToRing;

            //цвета машин
            List<Color> cols = new List<Color>() {
                Color.Red, Color.Green, Color.Blue
            };
            ColorCar = cols[_rand.Next(0, cols.Count-1)];
        }

		/// <summary>
		/// логика движения машины
		/// </summary>
		public void TryMoveForward()
		{
            if (GoalState == CarStates.MoveToRing)
            {
                MoveNext(Location.RoadNextCell);

                if (Location.TypePosition == PosTypes.Ring)
                    GoalState = CarStates.EntryRing;
            }
            else if (GoalState == CarStates.EntryRing)
            {
                MoveNext(Location.EntryNext);

                if (Location.LineNumber == NeedRingLineNumber)
                    GoalState = CarStates.MoveToDepart;
            }
            else if(GoalState == CarStates.MoveToDepart)
            {
                MoveNext(Location.RingNextCell);

                if(Location.TypeFunc == FuncTypes.EntryOrDepart)
                {
                    if (Location.Route == RouteTo)
                        GoalState = CarStates.DepartRing;
                }
            }
            else if(GoalState == CarStates.DepartRing)
            {
                MoveNext(Location.DepartNext);

                if(Location.TypePosition == PosTypes.Road)
                    GoalState = CarStates.DepartMap;
            }
            else if(GoalState == CarStates.DepartMap)
            {
                if (Location.RoadNextCell != null)
                    MoveNext(Location.RoadNextCell);
                else
                {
                    //уничтожение машины
                    Location.Car = null;
                    Environment.Cars.Remove(this);
                    OnCarDestroy(this);
                }
            }

		}

		/// <summary>
		/// переход на следующую клетку, если там нет пешехода и нет машины
		/// </summary>
		/// <param name="NextCell">клетка, в которую ехать</param>
		public void MoveNext(Cell NextCell)
		{
            //стоять если пешеход
            bool isCrossWalkStop =
                (NextCell.TypeFunc == FuncTypes.CrossWalk) &&
                ((Environment.Envir.Humans.Count > 0) || (Environment.Envir.LightsState == LightStates.Red));
            //стоять если машина
            bool isCarStop = (NextCell.Car != null);
            if (isCrossWalkStop || isCarStop) return;

            //изменяем положение машины
            Cell CelFrom = Location;
            Location.Car = null;
            NextCell.Car = this;
            Location = NextCell;

            //вызываем событие перемещения машины
            OnCarMove(this, CelFrom, Location);
		}

	}
}


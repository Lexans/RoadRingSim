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
		/// номер цвета машины
		/// </summary>
		public int ColorCar;

		/// <summary>
		/// желаемая линия кольца кольца исходя из RouteFrom и RouteTo
		/// </summary>
		public int NeedRingLineNumber {
            get {
                int k = ((int)RouteTo - (int)RouteFrom);
                if (k == 0)
                    return 4;
                else if (k < 0)
                    return 4+k;
                else
                    return k;
            }
        }

		public event EventCarDestroyHandler OnCarDestroy;

        public event EventCarMoveHandler OnCarMove;

		public Envirmnt Environment;

        private static Random _rand = new Random();
		/// <summary>
		/// создается новая машина произвольного цвета. Ее состояние - ожидание въезда
		/// направление RouteTo задается произвольно
		/// 
		/// </summary>
        public Car(Cell Location)
        {
            RouteTo = (Routes)(_rand.Next(1, 5));

            RouteFrom = Location.Route;
            this.Location = Location;

            GoalState = CarStates.MoveToRing;

            //цвета машин

            ColorCar = _rand.Next(0, 4);
        }

		/// <summary>
		/// логика движения машины
		/// </summary>
		public void TryMoveForward()
		{
            if (GoalState == CarStates.MoveToRing)
            {
                if (Location.RoadNextCell != null)
                    MoveNext(Location.RoadNextCell);
                else if (Location.EntryOrDepartNext != null)
                    MoveNext(Location.EntryOrDepartNext);

                if (Location.TypePosition == PosTypes.Ring)
                    GoalState = CarStates.EntryRing;
            }
            else if (GoalState == CarStates.EntryRing)
            {
                if (Location.LineNumber == Envirmnt.Inst.Cross.LinesRing ||
                    Location.LineNumber >= NeedRingLineNumber)
                    GoalState = CarStates.MoveToDepart;
                else
                    MoveNext(Location.EntryOrDepartNext);
            }
            else if(GoalState == CarStates.MoveToDepart)
            {
                MoveNext(Location.RingNextCell);

                if(Location.TypeFunc == FuncTypes.Depart)
                {
                    if (Location.Route == RouteTo)
                        GoalState = CarStates.DepartRing;
                }
            }
            else if(GoalState == CarStates.DepartRing)
            {
                MoveNext(Location.EntryOrDepartNext);

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
                    Envirmnt.Inst.Cars.Remove(this);
                    if (OnCarDestroy != null)
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
                ((Envirmnt.Inst.Humans.Count > 0) || (Envirmnt.Inst.LightsState == LightStates.Red));
            //стоять если машина
            bool isCarStop = (NextCell.Car != null);
            if (isCrossWalkStop || isCarStop) return;

            //изменяем положение машины
            Cell CelFrom = Location;
            Location.Car = null;
            NextCell.Car = this;
            Location = NextCell;

            //вызываем событие перемещения машины
            if (OnCarMove != null)
                OnCarMove(this, CelFrom, Location);
		}

	}
}


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core
{

    public delegate void EventHumanDestroyHandler(Human Model);
    public delegate void EventHumanMoveHandler(Human Model, Cell CellFrom, Cell CellTo);

	public sealed class Human
	{
		/// <summary>
		/// позиция (номер линии) относительно начала пешеходного перехода
		/// </summary>
		public Cell Location;

		/// <summary>
		/// произвольный цвет пешехода
		/// </summary>
		public Color ColorHuman;

		/// <summary>
		/// события уничтожения человекчка
		/// </summary>
		public event EventHumanDestroyHandler OnHumanDestroy;

		/// <summary>
		/// событие перемещения человечка
		/// </summary>
		public EventHumanMoveHandler OnHumanMove;

        private static Random _rand = new Random();

		/// <summary>
		/// создается новый человечек произвольного цвета
		/// </summary>
		public Human(Cell Location)
		{
            this.Location = Location;

            List<Color> cols = new List<Color>() {
                Color.Black, Color.Yellow, Color.Brown
            };
            ColorHuman = cols[_rand.Next(0, cols.Count - 1)];


		}

		/// <summary>
		/// если по CrossWalkCell.Next нет Car и Human, светофор отсутвует или горит красный, то переместиться вперед по NextCrossWalk
		/// </summary>
		public void TryMoveForward()
		{
            if (Location.CrosswalkNext.TypeFunc != FuncTypes.CrossWalk)
            {
                //уничтожение пешехода
                Location.CrosswalkPedestrian = null;
                Envirmnt.Inst.Humans.Remove(this);
                if (OnHumanDestroy != null)
                    OnHumanDestroy(this);

                return;
            }

            //стоять если машина или другой человек впереди
            bool isCarStop = (Location.CrosswalkNext.Car != null || Location.CrosswalkNext.CrosswalkPedestrian != null);

            if (isCarStop) return;

            //изменяем положение машины
            Cell CelFrom = Location;
            Location.CrosswalkPedestrian = null;
            CelFrom.CrosswalkNext.CrosswalkPedestrian = this;
            Location = CelFrom.CrosswalkNext;

            //вызываем событие перемещения машины
            OnHumanMove(this, CelFrom, Location);
		}

	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core
{
	public class Human
	{
		/// <summary>
		/// позиция (номер линии) относительно начала пешеходного перехода
		/// </summary>
		public CrossWalkCell Location;

		/// <summary>
		/// произвольный цвет пешехода
		/// </summary>
		public Color Color;

		/// <summary>
		/// события уничтожения человекчка
		/// </summary>
		public event EventHumanDestroyHandler OnHumanDestroy;

		/// <summary>
		/// событие перемещения человечка
		/// </summary>
		public EventHumanMoveHandler OnHumanMove;

		public Environment Environment;

		/// <summary>
		/// создается новый человечек произвольного цвета
		/// </summary>
		public Human()
		{
		}

		/// <summary>
		/// если по CrossWalkCell.Next нет Car и Human, светофор отсутвует или горит красный, то переместиться вперед по NextCrossWalk
		/// </summary>
		public virtual void TryMoveForward()
		{
			throw new System.NotImplementedException();
		}

	}
}


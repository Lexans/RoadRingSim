using RoadRingSim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core
{
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
		public Color Color;

		/// <summary>
		/// желаемая линия кольца кольца исходя из RouteFrom и RouteTo
		/// </summary>
		public int NeedRingLineNumber;

		public event EventCarDestroyHandler OnCarDestroy;

		public EventCarMoveHandler OnCarMove;

		public Environment Environment;

		/// <summary>
		/// создается новая машина произвольного цвета. Ее состояние - ожидание въезда
		/// направление RouteTo задается произвольно
		/// 
		/// </summary>
		public Car(Cell Location)
		{
		}

		/// <summary>
		/// логика движения машины
		/// </summary>
		public virtual void TryMoveForward()
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// переход на следующую клетку, если там нет пешехода и нет машины
		/// </summary>
		/// <param name="NextCell">клетка, в которую ехать</param>
		public virtual void MoveNext(Cell NextCell)
		{
			throw new System.NotImplementedException();
		}

	}
}


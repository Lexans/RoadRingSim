using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim
{
	public class Environment
	{
		public List<Car> Cars;

		public List<Human> Humans;

		public CrossRoad Cross;

		/// <summary>
		/// модельное время
		/// </summary>
		public ulong Time;

		public DistribustionLaw HumanDistr;

		public DistribustionLaw CarsDistr;

		/// <summary>
		/// карта объектов
		/// </summary>
		public Object[][] ObjectMap;

		/// <summary>
		/// ширина и высота поля
		/// </summary>
		public int SIZE;

		/// <summary>
		/// основной алгоритм моделирования движения
		/// </summary>
		public virtual void SimulationStep()
		{
			throw new System.NotImplementedException();
		}

	}
}


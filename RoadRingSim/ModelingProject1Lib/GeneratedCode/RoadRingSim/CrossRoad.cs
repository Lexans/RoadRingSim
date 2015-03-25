using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim
{
	public class CrossRoad
	{
		public Road Top;

		public Road Bottom;

		public Road Left;

		public Road Right;

		/// <summary>
		/// есть ли светофор на пешеходном переходе внизу
		/// </summary>
		public bool IsLights;

		public DistribustionLaw DistributionHumans;

		public DistribustionLaw DistribustionCars;

		public int ID;

		/// <summary>
		/// количество полос кольца
		/// </summary>
		public int RingLineAmount;

		public static CrossRoad ReadFromDatabase()
		{
			throw new System.NotImplementedException();
		}

	}
}


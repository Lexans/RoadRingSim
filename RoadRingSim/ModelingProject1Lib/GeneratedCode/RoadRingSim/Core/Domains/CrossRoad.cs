using RoadRingSim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core.Domains
{
	public sealed class CrossRoad : DomainObject
	{
		/// <summary>
		/// есть ли светофор на пешеходном переходе внизу
		/// </summary>
		public bool IsLights;

		public CrossRoadLaw DistributionHumans;

		public CrossRoadLaw DistribustionCars;

		/// <summary>
		/// количество полос кольца
		/// </summary>
		public int LinesRing;

		public string Name;

		public PriorityTypes PriorityType;

		public int LinesVertical;

		public int LinesHorisontal;

		public CrossRoad()
		{
		}

	}
}


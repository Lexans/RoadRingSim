using RoadRingSim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core.Domains
{
	public class CrossRoad : DomainObject
	{
		/// <summary>
		/// есть ли светофор на пешеходном переходе внизу
		/// </summary>
		public bool IsLights  { get; set; }

		public CrossRoadLaw DistributionHumans  { get; set; }

		public CrossRoadLaw DistribustionCars  { get; set; }

        public uint LightsTime  { get; set; }

		/// <summary>
		/// количество полос кольца
		/// </summary>
		public int LinesRing  { get; set; }

		public string Name  { get; set; }

		public PriorityTypes PriorityType  { get; set; }

		public int LinesVertical  { get; set; }

		public int LinesHorisontal  { get; set; }


		public CrossRoad()
		{

		}

	}
}


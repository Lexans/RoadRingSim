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
        public void SetPriority(int PriorityId)
        {
            switch (PriorityId)
            {
                case 0:
                    PriorityType = PriorityTypes.MainRing;
                    break;
                case 1:
                    PriorityType = PriorityTypes.SecondaryRing;
                    break;
                case 2:
                    PriorityType = PriorityTypes.MainStreetHorisontal;
                    break;
                case 3:
                    PriorityType = PriorityTypes.MainStreetVertical;
                    break;
            }
        }
        public int GetPriorityId()
        {
            int i = 0;
            switch (PriorityType)
            {
                case PriorityTypes.MainRing:
                    i = 0;
                    break;
                case PriorityTypes.SecondaryRing:
                    i = 1;
                    break;
                case PriorityTypes.MainStreetHorisontal:
                    i = 2;
                    break;
                case PriorityTypes.MainStreetVertical:
                    i = 3;
                    break;
            }
            return i;
        }

	}
}


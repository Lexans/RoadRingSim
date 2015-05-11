using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core
{

    public delegate void EventHumanCreateHandler(Human Model, Cell CellFrom); 

	public sealed class HumanCreator : ObjectCreator
	{
		public event EventHumanCreateHandler OnHumanCreate;

        Random _rand = new Random();
        public override void CreateObject()
        {
            Cell Location = Locations[_rand.Next(0, Locations.Count - 1)];

            if (Envirmnt.Inst.LightsState == LightStates.Red || !Envirmnt.Inst.Cross.IsLights)
            {
                Human hmn = new Human(Location);
                Location.CrosswalkPedestrian = hmn;
                Envirmnt.Inst.Humans.Add(hmn);

                if (OnHumanCreate != null)
                    OnHumanCreate(hmn, Location);
            }
        }

		public override void PlanNew()
		{
            TimeOfNextObj = Envirmnt.Inst.Time + Envirmnt.Inst.Cross.DistributionHumans.GetSample();
        }

	}
}


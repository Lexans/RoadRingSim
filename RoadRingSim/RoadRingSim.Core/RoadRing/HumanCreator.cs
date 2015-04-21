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

		public override void CreateObject()
		{
            Human hmn = new Human(Location);
            Location.Car = hmn;
            Environment.Envir.Humans.Add(hmn);

            OnHumanCreate(hmn, Location);
		}

		public override void PlanNew()
		{
            TimeOfNextObj = Environment.Envir.Time + Environment.Envir.Cross.DistributionHumans.GetSample();
        }

	}
}


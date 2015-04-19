using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core
{
	public sealed class HumanCreator : ObjectCreator
	{
		public event EventHumanCreateHandler OnHumanCreate;

		public override void CreateObject()
		{
			throw new System.NotImplementedException();
		}

		public override void PlanNew()
		{
			throw new System.NotImplementedException();
		}

	}
}


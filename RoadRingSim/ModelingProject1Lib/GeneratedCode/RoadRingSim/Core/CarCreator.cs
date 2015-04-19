using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core
{
	public sealed class CarCreator : ObjectCreator
	{
		/// <summary>
		/// событие создания машины
		/// </summary>
		public event EventCarCreateHandler OnCarCreate;

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


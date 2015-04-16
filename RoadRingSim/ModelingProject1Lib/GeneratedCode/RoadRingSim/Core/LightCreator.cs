using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core
{
	/// <summary>
	/// Изменение сигнала светофора
	/// </summary>
	public class LightCreator : ObjectCreator
	{
		public event EventLightsToggleHandler OnLightsToggle;

		/// <summary>
		/// переключает сигнал светофора, если светофор нужен на этой карте
		/// </summary>
		public override void CreateObject()
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// планирует переключение сигнала светофора через фиксированное время
		/// </summary>
		public override void PlanNew()
		{
			throw new System.NotImplementedException();
		}

	}
}


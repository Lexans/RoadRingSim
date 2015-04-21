using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core
{
    public delegate void EventLightsToggleHandler(LightStates LightState); 


	/// <summary>
	/// Изменение сигнала светофора
	/// </summary>
	public sealed class LightCreator : ObjectCreator
	{
		public event EventLightsToggleHandler OnLightsToggle;

		/// <summary>
		/// переключает сигнал светофора, если светофор нужен на этой карте
		/// </summary>
		public override void CreateObject()
		{

            if (Environment.Envir.Cross.IsLights)
            {
                switch (Environment.Envir.LightsState)
                {
                    case LightStates.Green:
                        Environment.Envir.LightsState = LightStates.Red;
                        break;

                    case LightStates.Red:
                        Environment.Envir.LightsState = LightStates.Green;
                        break;

                    case LightStates.None:
                        Environment.Envir.LightsState = LightStates.Green;
                        break;
                }
                OnLightsToggle(Environment.Envir.LightsState);
            }
     
		}

		/// <summary>
		/// планирует переключение сигнала светофора через фиксированное время
		/// </summary>
		public override void PlanNew()
		{
            TimeOfNextObj = Environment.Envir.Time + 20;
		}

	}
}


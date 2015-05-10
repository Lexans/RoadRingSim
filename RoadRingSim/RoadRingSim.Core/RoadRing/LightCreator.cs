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

            if (Envirmnt.Inst.Cross.IsLights)
            {
                switch (Envirmnt.Inst.LightsState)
                {
                    case LightStates.Green:
                        Envirmnt.Inst.LightsState = LightStates.Red;
                        break;

                    case LightStates.Red:
                        Envirmnt.Inst.LightsState = LightStates.Green;
                        break;

                    case LightStates.None:
                        Envirmnt.Inst.LightsState = LightStates.Green;
                        break;
                }

                if (OnLightsToggle != null)
                    OnLightsToggle(Envirmnt.Inst.LightsState);
            }
     
		}

		/// <summary>
		/// планирует переключение сигнала светофора через фиксированное время
		/// </summary>
		public override void PlanNew()
		{
            if (TimeOfNextObj == 0 && (OnLightsToggle != null))
                OnLightsToggle(Envirmnt.Inst.LightsState);

            TimeOfNextObj = Envirmnt.Inst.Time + Envirmnt.Inst.Cross.LightsTime;
		}

	}
}


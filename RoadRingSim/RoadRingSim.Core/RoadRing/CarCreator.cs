using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core
{
    public delegate void EventCarCreateHandler(Car Model, Cell CellFrom); 

    /// <summary>
    /// создатель машин на заданной клетке
    /// </summary>
	public sealed class CarCreator : ObjectCreator
	{
		/// <summary>
		/// событие создания машины
		/// </summary>
		public event EventCarCreateHandler OnCarCreate;

        public override void CreateObject()
		{
            Car cr = new Car(Location);
            Location.Car = cr;
            Envirmnt.Inst.Cars.Add(cr);

            OnCarCreate(cr, Location);
        }

		public override void PlanNew()
		{
            TimeOfNextObj = Envirmnt.Inst.Time + Envirmnt.Inst.Cross.DistribustionCars.GetSample();
        }

	}
}


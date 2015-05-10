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

        Random _rand = new Random();
        public override void CreateObject()
		{
            Cell Location = Locations[_rand.Next(0, Locations.Count)];

            Car cr = new Car(Location);
            Location.Car = cr;
            Envirmnt.Inst.Cars.Add(cr);

            if (OnCarCreate!= null)
             OnCarCreate(cr, Location);
        }

		public override void PlanNew()
		{
            TimeOfNextObj = Envirmnt.Inst.Time + Envirmnt.Inst.Cross.DistribustionCars.GetSample();
        }

	}
}


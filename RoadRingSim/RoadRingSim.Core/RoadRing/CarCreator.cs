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

        private override void CreateObject()
		{
            Car cr = new Car(Location);
            Location.Car = cr;
            Environment.Envir.Cars.Add(cr);

            OnCarCreate(cr, Location);
        }

		private override void PlanNew()
		{
            TimeOfNextObj = Environment.Envir.Time + Environment.Envir.Cross.DistribustionCars.GetSample();
        }

	}
}


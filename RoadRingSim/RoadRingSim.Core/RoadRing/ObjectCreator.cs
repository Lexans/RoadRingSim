using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core
{
	/// <summary>
	/// создатели новых объектов на карте
	/// </summary>
	public abstract class ObjectCreator
	{
		public ulong TimeOfNextObj;

		/// <summary>
		/// клектки, в которох будут созданы объекты
		/// </summary>
		public List<Cell> Locations;

		
		/// <summary>
		/// инициализирует поле TimeOfNextCar вызывая метод PlanNew
		/// </summary>
		public ObjectCreator()
		{
            Locations = new List<Cell>();
		}

		/// <summary>
		/// создает новый объект если пришло время и планирует следующий.
		/// Необходимо вызывать каждую единицу модельного времени
		/// </summary>
		public void TryCreate()
		{
            if (Envirmnt.Inst.Time > TimeOfNextObj || Envirmnt.Inst.Time == 0)
            {
                PlanNew();
                return;
            }

            if (Envirmnt.Inst.Time == TimeOfNextObj)
            {
                CreateObject();
                PlanNew();
            }
		}

		/// <summary>
		/// логика создания конкретного объекта
		/// </summary>
        public abstract void CreateObject();

        /// <summary>
        /// на основе реализации случайной величины вычисляет новое значение TimeOfNextCar
        /// </summary>
        public abstract void PlanNew();

	}
}


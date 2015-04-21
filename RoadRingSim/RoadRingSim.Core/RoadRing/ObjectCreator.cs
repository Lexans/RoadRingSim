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
		/// клектка, в которой будет создан объект
		/// </summary>
		public Cell Location;

		
		/// <summary>
		/// инициализирует поле TimeOfNextCar вызывая метод PlanNew
		/// </summary>
		public ObjectCreator()
		{
		}

		/// <summary>
		/// создает новый объект если пришло время и планирует следующий.
		/// Необходимо вызывать каждую единицу модельного времени
		/// </summary>
		public void TryCreate()
		{
            if (Environment.Envir.Time == TimeOfNextObj)
            {
                CreateObject();
                PlanNew();
            }

            if(Environment.Envir.Time > TimeOfNextObj)
                PlanNew();
		}

		/// <summary>
		/// логика создания конкретного объекта
		/// </summary>
        private abstract void CreateObject();

        /// <summary>
        /// на основе реализации случайной величины вычисляет новое значение TimeOfNextCar
        /// </summary>
        private abstract void PlanNew();

	}
}


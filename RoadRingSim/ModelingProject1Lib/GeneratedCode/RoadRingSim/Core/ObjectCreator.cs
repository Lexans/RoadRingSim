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
		public uint TimeOfNextCar;

		/// <summary>
		/// клектка, в которой будет создан объект
		/// </summary>
		public Cell Location;

		public Environment Environment;

		/// <summary>
		/// на основе реализации случайной величины вычисляет новое значение TimeOfNextCar
		/// </summary>
		public abstract void PlanNew();

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
		public virtual void TryCreate()
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// логика создания конкретного объекта
		/// </summary>
		public abstract void CreateObject();

	}
}


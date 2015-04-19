namespace RoadRingSim.Core
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	/// <summary>
	/// возможные состояния машины по типу текущей выполняемой задачи
	/// </summary>
	public enum CarStates : int
	{
		/// <summary>
		/// движение к кольцу
		/// </summary>
		MoveToRing,
		/// <summary>
		/// въезд на кольцо
		/// </summary>
		EntryRing,
		/// <summary>
		/// выезд из кольца
		/// </summary>
		DepartRing,
		/// <summary>
		/// движение по кольцу к выезду
		/// </summary>
		MoveToDepart,
        /// <summary>
        /// покидание карты
        /// </summary>
		DepartMap,
	}
}

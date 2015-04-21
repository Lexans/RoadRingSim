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
		MoveToRing = 1,
		/// <summary>
		/// въезд на кольцо
		/// </summary>
		EntryRing = 2,
        /// <summary>
        /// движение по кольцу к выезду
        /// </summary>
        MoveToDepart = 3,
		/// <summary>
		/// выезд из кольца
		/// </summary>
		DepartRing = 4,
        /// <summary>
        /// покидание карты
        /// </summary>
		DepartMap = 5,
	}
}

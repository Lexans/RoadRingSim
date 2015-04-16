using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core
{
	/// <summary>
	/// клетка, по котрой въезжают на кольцо на нужную полосу
	/// </summary>
	public class EntryCell : RingCell
	{
		/// <summary>
		/// ссылка на клетку следующей по счету полосы на кольце.
		/// требуется для занятия нужной полосы при въезде
		/// </summary>
		public EntryCell NextRingLine;

		/// <summary>
		/// направление въезда
		/// </summary>
		public Routes Route;

	}
}


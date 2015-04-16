using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core
{
	/// <summary>
	/// кольцо дороги
	/// </summary>
	public class RingCell : Cell
	{
		/// <summary>
		/// ссылка на клетку, в которую машина попадет двигаясь вперед
		/// </summary>
		public RingCell NextRingCell;

	}
}


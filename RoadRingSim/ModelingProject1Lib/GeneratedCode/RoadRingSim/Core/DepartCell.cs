using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core
{
	/// <summary>
	/// клетка, по которой выезжают из кольца
	/// </summary>
	public sealed class DepartCell : RingCell
	{
		/// <summary>
		/// направление выезда
		/// </summary>
		public Routes DepartRoute;

		public Cell NextDepart;

	}
}


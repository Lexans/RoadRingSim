using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core
{
	/// <summary>
	/// дорога вне колььца
	/// </summary>
	public class RoadCell : Cell, Cell
	{
		/// <summary>
		/// ссылка на клетку, в которую машина попадет двигаясь вперед
		/// </summary>
		public Cell NextRoadCell;

		/// <summary>
		/// расположение дороги
		/// </summary>
		public Routes Route;

        public RoadCell(int X, int Y): base(X, Y)
		{
		}

	}
}


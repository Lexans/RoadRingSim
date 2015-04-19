using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core
{
	/// <summary>
	/// клетка пешеходного перехода
	/// </summary>
	public sealed class CrossWalkCell : RoadCell
	{
		/// <summary>
		/// пешеход, находящийся в клетке пешехдного перехода
		/// </summary>
		public Human Pedestrian;

		/// <summary>
		/// следующая клетка для перехода по пешеходному переходу
		/// </summary>
		public CrossWalkCell NextCrossWalk;

	}
}


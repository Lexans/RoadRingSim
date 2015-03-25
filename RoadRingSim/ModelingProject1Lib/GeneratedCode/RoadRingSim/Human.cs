using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim
{
	public class Human
	{
		/// <summary>
		/// позиция относительно начала пешеходного перехода
		/// </summary>
		public object Position;

		public virtual void MoveForward()
		{
			throw new System.NotImplementedException();
		}

	}
}


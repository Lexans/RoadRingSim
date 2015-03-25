using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim
{
	public class Car
	{
		/// <summary>
		/// положение по горизонтали в клетках
		/// </summary>
		public int X;

		/// <summary>
		/// положение по вертикали в кретках
		/// </summary>
		public int Y;

		/// <summary>
		/// маршрут движения
		/// </summary>
		public Routes Route;

		public virtual void MoveUp()
		{
			throw new System.NotImplementedException();
		}

		public virtual void MoveDown()
		{
			throw new System.NotImplementedException();
		}

		public virtual void MoveLeft()
		{
			throw new System.NotImplementedException();
		}

		public virtual void MoveRight()
		{
			throw new System.NotImplementedException();
		}

		public virtual void MoveUpRight()
		{
			throw new System.NotImplementedException();
		}

		public virtual void MoveDownLeft()
		{
			throw new System.NotImplementedException();
		}

		public virtual void MoveDownRight()
		{
			throw new System.NotImplementedException();
		}

		public virtual void MoveUpLeft()
		{
			throw new System.NotImplementedException();
		}

	}
}


using RoadRingSim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core
{
	/// <summary>
	/// клетка среды симуляции
	/// </summary>
	public class Cell: Cell
	{
		/// <summary>
		/// машина текущей клетки (null если отсутвует)
		/// </summary>
		public Car Car;

		/// <summary>
		/// номер полосы
		/// нумерация начинается с единицы по правую сторону от направления движения
		/// </summary>
		public int LineNumber;

		public int X;

		public int Y;

		/// <summary>
		/// уровень приоритета клетки: 0 или 1
		/// </summary>
		public object Priority = 0;

		/// <summary>
		/// помещает клетку в позицию X,Y в Environment.CellMap
		/// </summary>
		public Cell(int X, int Y)
		{
            this.X = X;
            this.Y = Y;

            Environment.Envir.CellMap[X][Y] = this;
		}

	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim
{
	public sealed class Render
	{
		private static Graphics canvas;

		/// <summary>
		/// масштаб (размер клеток)
		/// </summary>
		public static int Scale;

		/// <summary>
		/// плавно перерисовывает машину из позиции XFrom,YFrom к текущему положению машины
		/// </summary>
		public static void RedrawCar(Car Car, object XFrom, object YFrom)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// перерисовка пешехода из позиции FromPos в новую позицию, взятую из Human.Pos
		/// </summary>
		public static void RedrawHuman(Human Crosswalk, int PosFrom)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// рисует дорогу и её знак
		/// </summary>
		public static void DrawRoad(Road Road)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// отрисовывает кольцо
		/// </summary>
		public static void DrawRing()
		{
			throw new System.NotImplementedException();
		}

	}
}


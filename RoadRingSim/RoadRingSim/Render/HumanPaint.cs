﻿using RoadRingSim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim
{
	public class HumanPaint : PaintTask
	{
		/// <summary>
		/// отрисовка перемещения пешехода из клетки CellFrom в CellTo с учетом шага задачи CurrentStep
		/// (всего шагов StepAmount)
		/// форма пешехода - кружочек
		/// </summary>
		/// <param name="Model">модель объекта, который визуализируем</param>
		public override void Paint(Object Model)
		{
			throw new System.NotImplementedException();
		}

	}
}


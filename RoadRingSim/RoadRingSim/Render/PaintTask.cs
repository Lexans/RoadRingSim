namespace RoadRingSim
{
    using RoadRingSim.Core;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;

	public abstract class PaintTask 
	{
        public Cell CellFrom;
        public Cell CellTo;
        public Point CurrentPos;
        public int CurrentStep;
        public int StepAmount;

		/// <summary>
		/// отрисовка текущего шага перемещения объекта из CellFrom в CellTo
		/// </summary>
		/// <param name="Model">модель объекта, который визуализируем</param>
		abstract public void Paint(Object Model);

	}
}


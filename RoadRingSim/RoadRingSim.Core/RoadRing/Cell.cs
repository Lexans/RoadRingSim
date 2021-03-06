﻿using RoadRingSim;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace RoadRingSim.Core
{
	/// <summary>
	/// клетка среды симуляции
	/// </summary>
	public class Cell
	{
        /// <summary>
        /// тип клетки по типу (дорога, кольцо)
        /// </summary>
        public PosTypes TypePosition;
        /// <summary>
        /// тип клетки по функции
        /// </summary>
        public FuncTypes TypeFunc;

        /*общее для всех клеток*/
        /// <summary>
        /// номер полосы
        /// нумерация начинается с единицы по правую сторону от направления движения
        /// </summary>
        public int LineNumber;

        public int X;

        public int Y;

        /// <summary>
        /// машина текущей клетки (null если отсутвует)
        /// </summary>
        public Car Car;

        /// <summary>
        /// уровень приоритета клетки: 0 или 1
        /// </summary>
        public object Priority = 0;


        /*общее для клеток дороги*/
        /// <summary>
        /// ссылка на клетку, в которую машина попадет двигаясь вперед по дороге
        /// </summary>
        public Cell RoadNextCell;
        
        /*общее для клеток кольца*/
        /// <summary>
        /// ссылка на клетку, в которую машина попадет двигаясь вперед по кольцу
        /// </summary>
        public Cell RingNextCell;

        
        /*Только для клеток CrossWalk*/
        /// <summary>
        /// пешеход, находящийся в клетке пешехдного перехода
        /// </summary>
        public Human CrosswalkPedestrian;

        /// <summary>
        /// следующая клетка для перехода по пешеходному переходу
        /// </summary>
        public Cell CrosswalkNext;


        /*Только для клеток EntryOrDepart*/
        /// <summary>
        /// ссылки на дорожки въезда и выезда
        /// </summary>
        public Cell EntryOrDepartNext;

        /// <summary>
        /// поизиция выезда или дороги
        /// </summary>
        public Routes Route;


		/// <summary>
		/// помещает клетку в позицию X,Y в Environment.CellMap
		/// </summary>
        public Cell(int X, int Y, PosTypes tp, FuncTypes tf)
		{
            this.X = X;
            this.Y = Y;

            TypePosition = tp;
            TypeFunc = tf;

            Envirmnt.Inst.CellMap[X][Y] = this;
		}

        public Cell(int X, int Y)
        {
            this.X = X;
            this.Y = Y;

            TypePosition = PosTypes.None;
            TypeFunc = FuncTypes.None;
        }

    }
}


using RoadRingSim;
using RoadRingSim.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core
{
	public class Environment
	{
		/// <summary>
		/// список всех машин
		/// </summary>
		public List<Car> Cars;

		public List<Human> Humans;

		public CrossRoad Cross;

		/// <summary>
		/// модельное время
		/// </summary>
		public ulong Time;

		/// <summary>
		/// матрица клеток окружения
		/// первая размерность - X (слева направо)
		/// вторая размерность - Y (сверху вниз)
        /// нумерация с 0
		/// если клетка клетка неактивна (на ней не может быть машин и пешеходов), то элемент = null
		/// </summary>
		public List<List<Cell>> CellMap;

		/// <summary>
		/// максимальная координата x и y
		/// </summary>
		public int SIZE = 30;

		/// <summary>
		/// состояние светофора
		/// </summary>
		public LightStates LightsState;
        
        /// <summary>
		/// объект-одиночка этого типа
		/// </summary>
        public static Environment Envir = new Environment();

        /// <summary>
        /// список создателей новых объектов (машин, пешеходов, сигналов светофора)
        /// </summary>
		public List<ObjectCreator> Creators;

		/// <summary>
		/// один шаг основного алгоритма моделирования движения
		/// требуется вызывать по таймеру
		/// </summary>
		public void SimulationStep()
		{
            //создание ноавых объектов
            foreach (var oc in Creators)
                oc.TryCreate();

			throw new System.NotImplementedException();
		}

		/// <summary>
		/// инициализация всех полей
		/// </summary>
		public Environment()
		{
            Cars = new List<Car>();
            Humans = new List<Human>();
            Time = 0;

            CellMap = new List<List<Cell>>(SIZE);
            for (int i = 0; i < SIZE; i++)
                CellMap[i] = new List<Cell>(SIZE);

            LightsState = LightStates.Green;
            Creators = new List<ObjectCreator>();
		}

		/// <summary>
		/// полное построение CellMap
		/// </summary>
		public void BuildMap()
		{
            for (int x = 16; x < 16 + Cross.LinesVertical; x++)
                for(int y = 0; y < 5; y++)
                {
                    new RoadCell(x,y);
                }
 

                throw new System.NotImplementedException();
		}

		/// <summary>
		/// отражает первый квадарант клеток карты на все остальные квадранты.
		/// Поля связи тоже переставляются
		/// </summary>
		private void QuadrantsReflect()
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// связывает все квадранты: устанавливает поля связи краев дорог кольца
		/// вызывать после ReflectQuadrant
		/// </summary>
		private void QuadrantsConnect()
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// инициализирует список ObjectCreator'ов
		/// </summary>
		public void InitObjectCreators()
		{
            //создатели машин на вертикальных дорогах
            for (int i = 0; i < Cross.LinesVertical; i++)
            {
                CarCreator cc = new CarCreator();
                cc.Location = CellMap[SIZE][16+i];
                Creators.Add(cc);

                cc.Location = CellMap[0][14 - i];
                Creators.Add(cc);
            }

            //создатели машин на горизонтальных дорогах
            for (int i = 0; i < Cross.LinesHorisontal; i++)
            {
                CarCreator cc = new CarCreator();
                cc.Location = CellMap[16 + i][0];
                Creators.Add(cc);

                cc.Location = CellMap[14 - i][SIZE];
                Creators.Add(cc);
            }

            HumanCreator hc = new HumanCreator();
            hc.Location = CellMap[28][14 - Cross.LinesVertical];
            Creators.Add(hc);

            if (Cross.IsLights)
            {
                LightCreator lc = new LightCreator();
                Creators.Add(lc);
            }
		}

	}
}


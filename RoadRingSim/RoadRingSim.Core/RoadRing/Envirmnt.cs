using RoadRingSim;
using RoadRingSim.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core
{
	public class Envirmnt
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
		/// состояние светофора
		/// </summary>
		public LightStates LightsState;
        
        /// <summary>
		/// объект-одиночка этого типа
		/// </summary>
        static Envirmnt  inst = null;
        public static Envirmnt Inst
        {
            get
            {
                if (inst == null)
                {
                    inst = new Envirmnt();
                }
                return inst;
            }
        }  

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
            //создание новых объектов
            foreach (var oc in Creators)
                oc.TryCreate();

            for (int i = 0; i < Humans.Count; i++)
                Humans[i].TryMoveForward();

            //учет приоритетов
            var ordCars = Cars.OrderBy(car => car.Location.Priority).ToList();

            foreach (Car car in ordCars)
                car.TryMoveForward();


            Time++;
		}

		/// <summary>
		/// инициализация всех полей
		/// </summary>
		private Envirmnt()
		{
            Cars = new List<Car>();
            Humans = new List<Human>();
            Time = 0;

            LightsState = LightStates.Green;
            Creators = new List<ObjectCreator>();
		}


        /// <summary>
        /// инициализация карты пустыми клетками
        /// </summary>
        private void InitMap()
        {
            //все клетки карты неопределенные
            CellMap = new List<List<Cell>>(31);
            for (int i = 0; i <= 30; i++)
            {
                CellMap.Add(new List<Cell>(31));

                for (int j = 0; j <= 30; j++)
                    CellMap[i].Add(new Cell(i, j));
            }
        }

        /// <summary>
        /// сбрасывает окружение до первоначального состояния
        /// </summary>
        public static void Reset()
        {
            inst = null;
        }


        /// <summary>
        /// строит только первый квадрант
        /// </summary>
        private void BuidFirstQuadrant()
        {
            //верхняя вертикальная дорога
            for (int x = 16; x < 16 + Cross.LinesVertical; x++)
                for (int y = 0; y < 5; y++)
                {
                    Cell cell = CellMap[x][y];
                    cell.TypePosition = PosTypes.Road;
                    cell.LineNumber = x - 15;

                    cell.Route = Routes.Top;

                    //выший приоритет если главная вертикальная улица, или кольцо второстепенное
                    cell.Priority = (Cross.PriorityType == PriorityTypes.MainStreetVertical
                        || Cross.PriorityType == PriorityTypes.SecondaryRing) ? 1 : 0;
                    
                    if(y > 0)
                     cell.RoadNextCell = CellMap[x][y-1];
                }

            //правая горизонтальная дорога
            for (int y = 14; y > 14 - Cross.LinesHorisontal; y--)
                for (int x = 26; x <= 30; x++)
                {
                    Cell cell = CellMap[x][y];
                    cell.TypePosition = PosTypes.Road;
                    cell.LineNumber = 15 - y;

                    cell.Route = Routes.Right;

                    //выший приоритет если главная вертикальная улица, или кольцо второстепенное
                    cell.Priority = (Cross.PriorityType == PriorityTypes.MainStreetHorisontal
                        || Cross.PriorityType == PriorityTypes.SecondaryRing) ? 1 : 0;


                    cell.RoadNextCell = CellMap[x-1][y];
                }


            //правая прямая часть кольца
            for (int x = 25; x > 25 - Cross.LinesRing; x--)
                for (int y = 11; y <= 15; y++)
                {

                    Cell rc = CellMap[x][y];
                    rc.TypePosition = PosTypes.Ring;
                    rc.LineNumber = 26-x;

                    rc.Route = Routes.Right;

                    rc.Priority = (Cross.PriorityType == PriorityTypes.MainStreetHorisontal
                       || Cross.PriorityType == PriorityTypes.MainRing) ? 1 : 0;

                    if (y != 11)
                        rc.RingNextCell = CellMap[x][y - 1];
                }


            //верхняя прямая часть кольца
            for (int x = 15; x <= 19; x++)
                for (int y = 5; y < 5 + Cross.LinesRing; y++)
                {
                    Cell rc = CellMap[x][y];
                    rc.TypePosition = PosTypes.Ring;
                    rc.LineNumber = y-4;

                    rc.Route = Routes.Top;

                    rc.Priority = (Cross.PriorityType == PriorityTypes.MainStreetVertical
                       || Cross.PriorityType == PriorityTypes.MainRing) ? 1 : 0;

                   rc.RingNextCell = CellMap[x - 1][y];
                }

            //дуга кольца 1 квадранта
            for (int line = 1; line <= Cross.LinesRing; line++)
            {
                //номер клетки дуги
                for (int cellnum = 1; cellnum <= (6 - line); cellnum++)
                {
                    int x = 19 + cellnum;
                    int y = 4 + cellnum + line;
                    Cell rc = CellMap[x][y];
                    rc.TypePosition = PosTypes.Ring;

                    rc.LineNumber = line;

                    rc.Priority = (Cross.PriorityType == PriorityTypes.MainStreetVertical ||
                        Cross.PriorityType == PriorityTypes.MainStreetHorisontal || Cross.PriorityType == PriorityTypes.MainRing) ? 1 : 0;

                    rc.RingNextCell = CellMap[rc.X - 1][rc.Y - 1];
                }
            }

            //связь правой прямой части кольца с дугой 1 квадранта
            for (int x = 25; x >= 26 - Cross.LinesRing; x--)
                CellMap[x][11].RingNextCell = CellMap[x - 1][10];


            //создание клекток выезда
            for (int x = 16; x < 16 + Cross.LinesVertical; x++)
                for (int y = 5; y < 5+Cross.LinesRing; y++)
                {
                    Cell cell = CellMap[x][y];

                    cell.TypeFunc = FuncTypes.Depart;

                    cell.EntryOrDepartNext = CellMap[x][y - 1];
                }

            //создание клеток для въезда
            for (int x = 26; x >= 25 - Cross.LinesRing; x--)
                for (int y = 15 - Cross.LinesHorisontal; y < 15; y++)
                {
                    Cell cell = CellMap[x][y];

                    if (x != 26)
                        cell.TypeFunc = FuncTypes.Entry;

                    cell.EntryOrDepartNext = CellMap[x-1][y];
                }
        }

        /// <summary>
        /// полное построение CellMap
        /// </summary>
        public void BuildMap()
        {
            InitMap();
            BuidFirstQuadrant();

            //отражение на 2ой квадрант
            QuadrantsReflect(
                (x) => { return x; },
                (y) => { return 30-y; },
                true,
                (route) => { return (route == Routes.Top) ? Routes.Bottom : Routes.Right; }
                );

            //отражение на 3ий квадрант
            QuadrantsReflect(
                (x) => { return 30 - x; },
                (y) => { return 30 - y; },
                false,
                (route) => { return (route == Routes.Top) ? Routes.Bottom : Routes.Left; }
                );

            //отражение на 4ый квадрант
            QuadrantsReflect(
                (x) => { return 30 - x; },
                (y) => { return y; },
                true,
                (route) => { return (route == Routes.Top) ? Routes.Top : Routes.Left; }
                );

            //создание пешеходного перехода
            for (int x = 14 - Cross.LinesVertical; x < 16 + Cross.LinesVertical; x++)
            {

                Cell cell = CellMap[x][28];
                cell.TypeFunc = FuncTypes.CrossWalk;

                cell.CrosswalkNext = CellMap[x + 1][28];
            }
        }


        public delegate int reflCord(int coord);
        public delegate Routes reflRoute(Routes route);

        /// <summary>
        /// отражает данные квадарант клеток карты на квадрант заданный функциями отражения
        /// </summary>
        /// <param name="rX"></param>
        /// <param name="rY"></param>
        /// <param name="islinkInverse"></param>
        /// <param name="rRoute"></param>
        private void QuadrantsReflect(reflCord rX, reflCord rY, bool islinkInverse, reflRoute rRoute)
		{
			for(int x = 15; x<=30; x++)
                for(int y = 0; y<=15; y++)
                {
                    //клетка 1 квадранта
                    Cell FromCell = CellMap[x][y];
                    //клетка целевого квадранта
                    Cell ToCell = CellMap[rX(x)][rY(y)];

                    //отражение направления выезда
                    ToCell.Route = rRoute(FromCell.Route);

                    //отражение констант
                    ToCell.Priority = FromCell.Priority;
                    ToCell.LineNumber = FromCell.LineNumber;
                    ToCell.TypeFunc = FromCell.TypeFunc;
                    ToCell.TypePosition = FromCell.TypePosition;


                    //отражение ссылок
                    if(islinkInverse) {
                        if (FromCell.RoadNextCell != null)
                            CellMap[rX(FromCell.RoadNextCell.X)][rY(FromCell.RoadNextCell.Y)].RoadNextCell = ToCell;

                         if (FromCell.RingNextCell != null)
                             CellMap[rX(FromCell.RingNextCell.X)][rY(FromCell.RingNextCell.Y)].RingNextCell = ToCell;

                        if (FromCell.EntryOrDepartNext != null)
                            CellMap[rX(FromCell.EntryOrDepartNext.X)][rY(FromCell.EntryOrDepartNext.Y)].
                                EntryOrDepartNext = ToCell;

                        //менеяем въезд на выезд, если нужно
                        if (ToCell.TypeFunc == FuncTypes.Entry)
                            ToCell.TypeFunc = FuncTypes.Depart;
                        else if (ToCell.TypeFunc == FuncTypes.Depart)
                            ToCell.TypeFunc = FuncTypes.Entry;

                    }
                    else
                    {
                        if (FromCell.RoadNextCell != null)
                            ToCell.RoadNextCell = CellMap[rX(FromCell.RoadNextCell.X)][rY(FromCell.RoadNextCell.Y)];

                        if (FromCell.RingNextCell != null)
                            ToCell.RingNextCell = CellMap[rX(FromCell.RingNextCell.X)][rY(FromCell.RingNextCell.Y)];

                        if (FromCell.EntryOrDepartNext != null)
                            ToCell.EntryOrDepartNext = CellMap[rX(FromCell.EntryOrDepartNext.X)][rY(FromCell.EntryOrDepartNext.Y)];
                    }

                    
                }
		}


		/// <summary>
		/// инициализирует список ObjectCreator'ов
		/// </summary>
		public void InitObjectCreators()
		{
            CarCreator cc = new CarCreator();
            //создатели машин на вертикальных дорогах
            for (int i = 0; i < Cross.LinesVertical; i++)
            {
                cc.Locations.Add(CellMap[16 + i][30]);
                Creators.Add(cc);

                cc.Locations.Add(CellMap[14 - i][0]);
                Creators.Add(cc);
            }

            //создатели машин на горизонтальных дорогах
            for (int i = 0; i < Cross.LinesHorisontal; i++)
            {
                cc.Locations.Add(CellMap[0][16 + i]);
                Creators.Add(cc);

                cc.Locations.Add(CellMap[30][14 - i]);
                Creators.Add(cc);
            }

            HumanCreator hc = new HumanCreator();
            hc.Locations.Add(CellMap[14 - Cross.LinesVertical][28]);
            //hc.Locations.Add(CellMap[16 + Cross.LinesVertical][12]);
            Creators.Add(hc);

            if (Cross.IsLights)
            {
                LightCreator lc = new LightCreator();
                Creators.Add(lc);
            }
		}

	}
}


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
            //создание ноавых объектов
            foreach (var oc in Creators)
                oc.TryCreate();

            //foreach (Human hmn in Humans)
                //hmn.TryMoveForward();

            //учет приоритетов
            var ordCars = Cars.OrderBy(car => car.Location.Priority);

            foreach (Car car in ordCars)
                car.TryMoveForward();

		}

		/// <summary>
		/// инициализация всех полей
		/// </summary>
		public Envirmnt()
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
                    
                    cell.RoadNextCell = CellMap[x][y+1];
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
                    rc.LineNumber = x - 22;

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
                    rc.LineNumber = y - 4;

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
            CellMap[5][19].TypeFunc = FuncTypes.EntryOrDepart;
            CellMap[5][19].DepartNext = CellMap[4][19];
            CellMap[6][20].TypeFunc = FuncTypes.EntryOrDepart;
            CellMap[6][20].DepartNext = CellMap[5][19];

            Cell dc;
            if ((dc = CellMap[7][20]).TypePosition != PosTypes.None)
            {
                dc.TypeFunc = FuncTypes.EntryOrDepart;
                dc.DepartNext = CellMap[6][20];
            }

            if ((dc = CellMap[8][21]).TypePosition != PosTypes.None)
            {
                dc.TypeFunc = FuncTypes.EntryOrDepart;
                dc.DepartNext = CellMap[7][20];
            }

            if ((dc = CellMap[9][21]).TypePosition != PosTypes.None)
            {
                dc.TypeFunc = FuncTypes.EntryOrDepart;
                dc.DepartNext = CellMap[8][21];
            }

            if ((dc = CellMap[10][22]).TypePosition != PosTypes.None)
            {
                dc.TypeFunc = FuncTypes.EntryOrDepart;
                dc.DepartNext = CellMap[9][21];
            }

            if ((dc = CellMap[11][22]).TypePosition != PosTypes.None)
            {
                dc.TypeFunc = FuncTypes.EntryOrDepart;
                dc.DepartNext = CellMap[10][22];
            }


            Cell ec;
            //создание клеток для въезда
            for (int y = 11; y <= 14; y++)
            {
                ec = CellMap[25][y];
                ec.TypeFunc = FuncTypes.EntryOrDepart;
                ec.EntryNext = CellMap[24][y];

                if ((ec = CellMap[24][y]).TypePosition != PosTypes.None)
                {
                    ec.TypeFunc = FuncTypes.EntryOrDepart;
                    ec.EntryNext = CellMap[23][y - 1];
                }

                if ((ec = CellMap[23][y - 1]).TypePosition != PosTypes.None)
                {
                    ec.TypeFunc = FuncTypes.EntryOrDepart;
                    ec.EntryNext = CellMap[22][y - 2];
                }
            }

            for (int y = 9; y <= 10; y++)
            {
                if ((ec = CellMap[22][y]).TypePosition != PosTypes.None)
                {
                    ec.TypeFunc = FuncTypes.EntryOrDepart;
                    ec.EntryNext = CellMap[21][y];
                }
            }

            if ((ec = CellMap[21][9]).TypePosition != PosTypes.None)
            {
                ec.TypeFunc = FuncTypes.EntryOrDepart;
                ec.EntryNext = CellMap[20][9];
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
            for(int x = 10; x <= 19; x++)
            {
                Cell c = CellMap[x][28];
                c.TypeFunc = FuncTypes.CrossWalk;
                
                if(x != 19)
                    c.CrosswalkNext = CellMap[x+1][28];
            }
        }


        public delegate int reflCord(int coord);
        public delegate Routes reflRoute(Routes route);
		/// <summary>
		/// отражает данные квадарант клеток карты на квадрант заданный функциями отражения
		/// </summary>
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
                    if (FromCell.RoadNextCell != null)
                    {
                        if (islinkInverse)
                        {
                            CellMap[rX(FromCell.RoadNextCell.X)][rY(FromCell.RoadNextCell.Y)].RoadNextCell = ToCell;
                        }
                        else
                            ToCell.RoadNextCell = CellMap[rX(FromCell.RoadNextCell.X)][rY(FromCell.RoadNextCell.Y)];
                    }

                    if (FromCell.RingNextCell != null)
                    {
                        if (islinkInverse)
                        {
                            CellMap[rX(FromCell.RingNextCell.X)][rY(FromCell.RingNextCell.Y)].RingNextCell = ToCell;
                        }
                        else
                            ToCell.RingNextCell = CellMap[rX(FromCell.RingNextCell.X)][rY(FromCell.RingNextCell.Y)];
                    }
                }
		}


		/// <summary>
		/// инициализирует список ObjectCreator'ов
		/// </summary>
		public void InitObjectCreators()
		{
            CarCreator cc0 = new CarCreator();
            cc0.Location = CellMap[30][14];
            Creators.Add(cc0);
            return;

            //создатели машин на вертикальных дорогах
            for (int i = 0; i < Cross.LinesVertical; i++)
            {
                CarCreator cc = new CarCreator();
                cc.Location = CellMap[16 + i][30];
                Creators.Add(cc);

                cc.Location = CellMap[14 - i][0];
                Creators.Add(cc);
            }

            //создатели машин на горизонтальных дорогах
            for (int i = 0; i < Cross.LinesHorisontal; i++)
            {
                CarCreator cc = new CarCreator();
                cc.Location = CellMap[0][16 + i];
                Creators.Add(cc);

                cc.Location = CellMap[30][14 - i];
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


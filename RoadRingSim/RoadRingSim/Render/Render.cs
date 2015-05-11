using RoadRingSim.Core;
using RoadRingSim.Core.Domains;
using RoadRingSim.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace RoadRingSim
{
	/// <summary>
	/// класс отрисовки среды симуляции.
	/// должен отслеживать состояние модели и обновлять визуализацию
	/// </summary>
	public sealed class Render
	{
		public Graphics Canvas;

		/// <summary>
		/// масштаб (размер клеток в пикселах)
		/// </summary>
		public int Scale = 21;

		/// <summary>
		/// поле содержит единственный экземпляр класса Render
		/// </summary>
        /// <summary>
        /// объект-одиночка этого типа
        /// </summary>
        static Render inst = null;
        public static Render Inst
        {
            get
            {
                if (inst == null)
                {
                    inst = new Render();
                }
                return inst;
            }

        }

        public static void Reset()
        {
            inst = null;
        }

		/// <summary>
		/// полная картинка карты по сбросу
		/// </summary>
		public Image DefaultMap;

		/// <summary>
		/// объекты, ассоциированные со очередью задач визуализации их движения
		/// </summary>
		public Dictionary<Object,Queue<PaintTask>> Tasks;

		/// <summary>
		/// задержка между выполнениями шагов задач
		/// </summary>
		public int SleepDelay;

		/// <summary>
		/// отрисовка DefaultMap
		/// </summary>
		public void DrawMap()
		{
            //отрисовка фона
            foreach(List<Cell> lc in Envirmnt.Inst.CellMap)
                foreach(Cell c in lc)
                {
                    if (c.TypePosition == PosTypes.None)
                        PaintCell(Color.FromArgb(255, 39, 126, 13), c);
                }

			foreach(List<Cell> lc in Envirmnt.Inst.CellMap)
                foreach(Cell c in lc)
                {
                    if (c.TypePosition != PosTypes.None)
                        PaintCell(Color.Gray, c);

                    //отрисовка скруглений дороги
                    if (c.TypePosition == PosTypes.Ring)
                        Canvas.DrawLine(
                            new Pen(Color.Gray, Scale+8),
                            (int) ((c.X+0.5) * Scale),
                            (int)((c.Y + 0.5) * Scale),
                            (int)((c.RingNextCell.X + 0.5) * Scale),
                            (int)((c.RingNextCell.Y + 0.5) * Scale));

                    
                }

            DrawSigns(Envirmnt.Inst.Cross.PriorityType);
		}

		/// <summary>
		/// отрисовка всех знаков приоритета в зависимости от типа приоритетов
		/// </summary>
		/// <param name="PriorityType">тип приоритетов движения</param>
		private void DrawSigns(PriorityTypes PriorityType)
		{
            var clMap = Envirmnt.Inst.CellMap;

            //пешеходный переход
            PaintCell(Pictures.signCrosswalk, clMap[10][27]);
            PaintCell(Pictures.signCrosswalk, clMap[20][29]);

            //знаки кругового движения
            PaintCell(Pictures.signRing, clMap[20][28]);
            PaintCell(Pictures.signRing, clMap[2][20]);
            PaintCell(Pictures.signRing, clMap[10][2]);
            PaintCell(Pictures.signRing, clMap[28][10]);

            Image prTypeSign = null;
            //списко картинок других знаков по часовой стрелке
            Image[] otherSigns = new Image[8];

            switch(Envirmnt.Inst.Cross.PriorityType)
            {
                case PriorityTypes.MainRing:
                    prTypeSign = Pictures.signMainRing;
                    otherSigns[0] = otherSigns[2] = otherSigns[4] = otherSigns[6] =  Pictures.signYieldVertical;
                    otherSigns[1] = otherSigns[3] = otherSigns[5] = otherSigns[7] = Pictures.signMain;
                    break;

                case PriorityTypes.SecondaryRing:
                    prTypeSign = null;
                    otherSigns[0] = otherSigns[2] = otherSigns[4] = otherSigns[6] =  Pictures.signMain;
                    otherSigns[1] = otherSigns[3] = otherSigns[5] = otherSigns[7] = Pictures.signYieldVertical;
                    break;

                case PriorityTypes.MainStreetHorisontal:
                    prTypeSign = Pictures.signMainHorisontal;
                    otherSigns[0] = otherSigns[4] = otherSigns[6] = Pictures.signYieldVertical;
                    otherSigns[1] = otherSigns[3] = otherSigns[5] = otherSigns[7] = Pictures.signMain;
                    otherSigns[2] = Pictures.signMain;
                    otherSigns[3] = Pictures.signYieldVertical;
                    break;

                case PriorityTypes.MainStreetVertical:
                    prTypeSign = Pictures.signMainHorisontal;
                    otherSigns[0] = otherSigns[2] = otherSigns[6] =  Pictures.signYieldVertical;
                    otherSigns[1] = otherSigns[3] = otherSigns[7] = Pictures.signMain;

                    otherSigns[4] = Pictures.signMain;
                    otherSigns[5] = Pictures.signYieldVertical;
                    break;
           
            }


            //отрисовка схемы приоритетов
            PaintCell(prTypeSign, clMap[10][3]);
            PaintCell(prTypeSign, clMap[27][10]);
            PaintCell(prTypeSign, clMap[20][27]);
            PaintCell(prTypeSign, clMap[3][20]);

            //отрисовка других знаков
            PaintCell(otherSigns[0], clMap[10][4]);
            PaintCell(otherSigns[1], clMap[15][4]);
            PaintCell(otherSigns[2], clMap[26][10]);
            PaintCell(otherSigns[3], clMap[26][15]);
            PaintCell(otherSigns[4], clMap[20][26]);
            PaintCell(otherSigns[5], clMap[15][26]);
            PaintCell(otherSigns[6], clMap[4][20]);
            PaintCell(otherSigns[7], clMap[4][15]);


		}

        private void PaintCell(Image img, Cell cl)
        {
            if (img != null)
                Canvas.DrawImage(img, cl.X * Scale, cl.Y * Scale, img.Width, img.Height);
        }

		/// <summary>
		/// на основе объекта Environment рисует DefaultMap
		/// связывает методы добавления элементов в очередь по событиям
		/// </summary>
		private Render()
		{
            Tasks = new Dictionary<object, Queue<PaintTask>>();
            //регистрируемся на события создания объектов
            foreach (ObjectCreator oc in Envirmnt.Inst.Creators)
            {
                if(oc is CarCreator)
                {
                    ((CarCreator)oc).OnCarCreate += EventHandlerCarCreate;
                }
                else if(oc is HumanCreator)
                {
                    ((HumanCreator)oc).OnHumanCreate += EventHandlerHumanCreate;
                }
                else if(oc is LightCreator)
                {
                    ((LightCreator)oc).OnLightsToggle += EventHandlerLightToggle;
                }
            }
		}

		/// <summary>
		/// для всех задач из словаря Tasks выполняет один шаг задач из головы очереди
		/// полностью выполненная задача удаляется из очереди
		/// Необходимо вызвать в отдельном потоке.
		/// </summary>
		private void DoTaskStep()
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// в цикле: сбрасывает карту картинкой DefaultMap, вызывает шаг отрисовки, делает задержку
		/// этот метод запускается в отдельном потоке паралельно с работающим по таймеру Environment
		/// </summary>
		public void DoTasks()
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// обработчик события создания машины:
		/// добавляет очерель задач для новой машины
		/// подписывается на перемещения машин
		/// </summary>
		public void EventHandlerCarCreate(Car Model, Cell CellFrom)
		{
            Tasks[Model] = new Queue<PaintTask>();

            Model.OnCarMove += EventHandlerCarMove;
            Model.OnCarDestroy += EventHandlerCarDestroy;
		}

		/// <summary>
		/// обработчик события удаления машины
		/// удаляет из Tasks очередь задач отрисовки для данной машины
		/// </summary>
		public void EventHandlerCarDestroy(Car Model)
		{
            Tasks.Remove(Model);

            PaintCell(Color.Gray, Model.Location);
		}

		/// <summary>
		/// обработчик события создания пешехода
		/// подписывается на перещения пешехода
		/// </summary>
		public void EventHandlerHumanCreate(Human Model, Cell CellFrom)
		{
            Tasks[Model] = new Queue<PaintTask>();

            Model.OnHumanMove += EventHandlerHumanMove;
            Model.OnHumanDestroy += EventHandlerHumanDestroy;
		}

		/// <summary>
		/// обработчик события уничтожения человечка
		/// </summary>
		/// <param name="Model">уничтожаемый пешеход</param>
		public void EventHandlerHumanDestroy(Human Model)
		{
            Tasks.Remove(Model);

            PaintCell(Color.Gray, Model.Location);
		}

		/// <summary>
		/// обработчик события перемещения машины
		/// добавляет в очередь задач отрисовки соотв задачу
		/// </summary>
		public void EventHandlerCarMove(Car Model, Cell CellFrom, Cell CellTo)
		{
            CarPaint cp = new CarPaint();
            cp.CellFrom = CellFrom;
            cp.CellTo = Model.Location;

            Tasks[Model].Enqueue(cp);

            //старую позицию закрашиваем
            PaintCell(Color.Gray, CellFrom);

            /*
            //растроваые машинки
            List<Bitmap> sprites = new List<Bitmap>()
            { Pictures.spriteCar1, Pictures.spriteCar2, Pictures.spriteCar3, Pictures.spriteCar4};
            float angle = (float)(Math.Atan((double)(CellTo.Y - CellFrom.Y)
                / (double)(CellTo.X - CellFrom.X)) * 180.0 / Math.PI);
            Bitmap bm = new Bitmap(21, 21);
            Graphics car = Graphics.FromImage(bm);
            Matrix m = new Matrix();
            m.RotateAt(angle, new Point(10, 10));
            car.Transform = m;
            TextureBrush tBrush = new TextureBrush(sprites[Model.ColorCar]);
            car.FillRectangle(tBrush, 0, 0, 21, 21); 
            car.Flush();
            Canvas.DrawImage(bm, CellTo.X * Scale, CellTo.Y * Scale);
            */

            //векторная машинка
            
            List<Color> colors = new List<Color>() { Color.Yellow, Color.Red, Color.Blue, Color.Black};
            float angle = (float)(Math.Atan((double)(CellTo.Y - CellFrom.Y)
                / (double)(CellTo.X - CellFrom.X)) * 180.0 / Math.PI);
            Bitmap bm = new Bitmap(21, 21);
            Graphics car = Graphics.FromImage(bm);
            Matrix m = new Matrix();
            m.RotateAt(angle, new Point(10, 10));
            car.Transform = m;
            car.FillRectangle(new SolidBrush(colors[Model.ColorCar]), 2, 5, 17, 9); 
            car.Flush();
            Canvas.DrawImage(bm, CellTo.X * Scale, CellTo.Y * Scale);
		}

		public void EventHandlerHumanMove(Human Model, Cell CellFrom, Cell CellTo)
		{
            HumanPaint hp = new HumanPaint();
            hp.CellFrom = CellFrom;
            hp.CellTo = Model.Location;

            Tasks[Model].Enqueue(hp);

            PaintCell(Color.Gray, CellFrom);

            
            Canvas.FillRectangle(
                new SolidBrush(Model.ColorHuman),
                CellTo.X * Scale + 5,
                CellTo.Y * Scale + 5,
                11,
                11);
		}

        private void PaintCell(Color col, Cell cl)
        {
                Canvas.FillRectangle(new SolidBrush(col), cl.X * Scale, cl.Y * Scale, Scale, Scale);
        }

		/// <summary>
		/// обработчик события изменения сигнала светофора
		/// </summary>
		/// <param name="LightState">новое состояние светофора</param>
		public void EventHandlerLightToggle(LightStates LightState)
		{
            //тут рисуем цвет светофора
            if (LightState == LightStates.Green)
            {
                PaintCell(Pictures.lightGreen, Envirmnt.Inst.CellMap[15][29]);
            }
            else if (LightState == LightStates.Red)
            {
                PaintCell(Pictures.lightRed, Envirmnt.Inst.CellMap[15][29]);
            }
		}

	}
}


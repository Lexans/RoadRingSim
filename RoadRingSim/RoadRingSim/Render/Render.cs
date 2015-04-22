using RoadRingSim.Core;
using RoadRingSim.Core.Domains;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
			foreach(List<Cell> lc in Envirmnt.Inst.CellMap)
                foreach(Cell c in lc)
                {
                    if (c.TypePosition != PosTypes.None)
                        PaintCell(Color.Gray, c);
                }
		}

		/// <summary>
		/// отрисовка всех знаков приоритета в зависимости от типа приоритетов
		/// </summary>
		/// <param name="PriorityType">тип приоритетов движения</param>
		private void DrawSigns(PriorityTypes PriorityType)
		{
			throw new System.NotImplementedException();
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

            PaintCell(Color.Gray, CellFrom);
            PaintCell(Model.ColorCar, CellTo);
		}

		public void EventHandlerHumanMove(Human Model, Cell CellFrom, Cell CellTo)
		{
            HumanPaint hp = new HumanPaint();
            hp.CellFrom = CellFrom;
            hp.CellTo = Model.Location;

            Tasks[Model].Enqueue(hp);

            PaintCell(Color.Gray, CellFrom);
            PaintCell(Model.ColorHuman, CellTo);
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
                PaintCell(Color.Green, Envirmnt.Inst.CellMap[15][27]);
            else if(LightState == LightStates.Red)
                PaintCell(Color.Red, Envirmnt.Inst.CellMap[15][27]);
		}

	}
}


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
		/// список всех машин. Сначала сортируется по приоритету по клетки
		/// потом по признаку нахождения на дороге (дорога приоритетнее кольцо)
		/// 
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
		public LigthStates LightsState;

		/// <summary>
		/// объект-одиночка этого типа
		/// </summary>
		public static Environment Envir;

		public List<ObjectCreator> Creators;

		/// <summary>
		/// один шаг основного алгоритма моделирования движения
		/// требуется вызывать по таймеру
		/// </summary>
		public virtual void SimulationStep()
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// инициализация всех полей
		/// </summary>
		public Environment()
		{
		}

		/// <summary>
		/// полное построение CellMap
		/// </summary>
		public virtual void BuildMap()
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// вызывает все ObjectCreator'ы из списка Creators
		/// для создания новых машин и пешеходов
		/// </summary>
		private void CreateAllNewObject()
		{
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
		public virtual void InitObjectCreators()
		{
			throw new System.NotImplementedException();
		}

	}
}


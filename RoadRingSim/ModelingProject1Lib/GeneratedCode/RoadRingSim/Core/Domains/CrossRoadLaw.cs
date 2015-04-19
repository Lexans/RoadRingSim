using RoadRingSim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core.Domains
{
	public sealed class CrossRoadLaw
	{
		public DistrubutionLaws Type;

		public double Parametr1;

		public double Parametr2;

		public CrossRoadLaw(DistributionLaws LawType)
		{
		}

		/// <summary>
		/// реализация СВ по текущему закону из Type
		/// </summary>
		public void GetSample()
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Реализация экпоненциальной СВ. Параметр param1. Округляется до ближайшего целого
		/// </summary>
		private void GetExpon()
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Реализация нормальной СВ. Параметр mx = param1, dx = param2. Округляется до ближайшего целого
		/// </summary>
		private void GetNormal()
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Реализация нормальной СВ. Левая граница = param1, правая граница = param2. Округляется до ближайшего целого
		/// </summary>
		private void GetUniform()
		{
			throw new System.NotImplementedException();
		}

	}
}


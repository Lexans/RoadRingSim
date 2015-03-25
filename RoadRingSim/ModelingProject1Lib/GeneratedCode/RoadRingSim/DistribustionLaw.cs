using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim
{
	public class DistribustionLaw
	{
		public DistrubutionTypes Type;

		public double Param1;

		public double Param2;

		public virtual void DistributionLaw()
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// реализация СВ по текущему закону из Type
		/// </summary>
		public virtual void GetSample()
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


using RoadRingSim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core.Domains
{
	public sealed class CrossRoadLaw
	{
		public DistrubutionLaws Type {get; set;}

        public double Parametr1 { get; set; }

        public double Parametr2 { get; set; }

        private static Random _rand = new Random();
        public CrossRoadLaw(int LowId)
        {
            switch (LowId)
            {
                case 0:
                    Type = DistrubutionLaws.Normal;
                    break;
                case 1:
                    Type = DistrubutionLaws.Expon;
                    break;
                case 2:
                    Type = DistrubutionLaws.Uniform;
                    break;
            }
        }
        public CrossRoadLaw(DistrubutionLaws LawType)
		{
            Type = LawType;
		}
        public int GetIndexLaw()
        {
            int i = 0;
            switch (Type)
            {
                case DistrubutionLaws.Normal:
                    i = 0;
                    break;
                case DistrubutionLaws.Expon:
                    i = 1;
                    break;
                case DistrubutionLaws.Uniform:
                    i = 2;
                    break;
            }
            return i;
        }
		/// <summary>
		/// реализация СВ по текущему закону из Type
		/// </summary>
		public uint GetSample()
		{
            int result = 0;

            switch (Type)
            {
                case DistrubutionLaws.Expon:
                    result = GetExpon();
                    break;
                case DistrubutionLaws.Normal:
                    result = GetNormal();
                    break;
                case DistrubutionLaws.Uniform:
                    result = GetUniform();
                    break;
            }

            return (uint)result;
		}

		/// <summary>
		/// Реализация экпоненциальной СВ. Параметр param1. Округляется до ближайшего целого
		/// </summary>
		private int GetExpon()
		{
            double x = _rand.NextDouble();
            return (int)Math.Ceiling(-1.0 / Parametr1 * Math.Log(x));
		}

		/// <summary>
		/// Реализация усеченно0нормальной СВ. Параметр mx = param1, dx = param2. Округляется до ближайшего целого
		/// </summary>
        private int GetNormal()
		{
            double sum;
            double x;

        CalcX:
            sum = 0;
            for (int i = 0; i < 12; i++)
                sum += _rand.NextDouble();

            x = Math.Sqrt(Parametr2) * (sum - 6) + Parametr1;
            if (x <= 0)
                goto CalcX;

            return (int)x;
		}

		/// <summary>
		/// Реализация нормальной СВ. Левая граница = param1, правая граница = param2. Округляется до ближайшего целого
		/// </summary>
        private int GetUniform()
		{
            if (Parametr2 < Parametr1)
                Parametr2 = Parametr1 + 1;

            return _rand.Next((int)Parametr1, (int)Parametr2);
		}

        public override String ToString() {
            switch (Type)
            {
                case DistrubutionLaws.Expon:
                    return "ЭКСП(" + Parametr1+")";
                case DistrubutionLaws.Normal:
                    return "НОРМ(" + Parametr1 + "; "+Parametr2+")";
                case DistrubutionLaws.Uniform:
                    return "РАВН(" + Parametr1 + "; " + Parametr2 + ")";
                default:
                    return "неопределно";
            }
        }

	}
}


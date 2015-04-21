namespace RoadRingSim.Core
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	/// <summary>
	/// состояние светофора для машин
	/// </summary>
	public enum LightStates : int
	{
		/// <summary>
		/// светофор отсутвует
		/// </summary>
		None = 0,
		Red = 1,
		Green = 2,
	}
}

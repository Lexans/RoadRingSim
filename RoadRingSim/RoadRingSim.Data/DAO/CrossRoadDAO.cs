using RoadRingSim.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Data.DAO
{
	/// <summary>
	/// Управление моделями перекрстков в базе данных
	/// </summary>
	public sealed class CrossRoadDAO : DAO
	{
		public CrossRoad Insert(CrossRoad cr)
		{
            cr.ID = GetMaxID("CrossRoad") + 1;

            //модель перекрестка
            ExecuteQuery(
                String.Format(
                "INSERT INTO `CrossRoad`(`ID`,`Name`,`IsLights`,`LinesVertical`, `LinesHorisontal`, "+
                "`LinesRing`, `PriorityType`, `LightsTime`) VALUES ({0},\"{1}\",{2},{3},{4},{5},{6},{7});",
                cr.ID, cr.Name, (cr.IsLights) ? "1" : "0", cr.LinesVertical, cr.LinesHorisontal, cr.LinesRing, (int)cr.PriorityType, cr.LightsTime));

            //распределение машин
            ExecuteQuery(
                String.Format(
                "INSERT INTO `CrossRoadLaw`(`IDCrossRoad`,`IDLaw`,`LawOfWhat`,`Parametr1`, `Parametr2`) "+
                "VALUES ({0},{1},{2},{3},{4});",
                cr.ID, (int) cr.DistribustionCars.Type, 1, Convert.ToString(cr.DistribustionCars.Parametr1).Replace(',', '.'), Convert.ToString(cr.DistribustionCars.Parametr2).Replace(',', '.')));

            //распределение пешеходов
            ExecuteQuery(
                String.Format(
                "INSERT INTO `CrossRoadLaw`(`IDCrossRoad`,`IDLaw`,`LawOfWhat`,`Parametr1`, `Parametr2`) "+
                "VALUES ({0},{1},{2},{3},{4});",
                cr.ID, (int)cr.DistributionHumans.Type, 2, Convert.ToString(cr.DistributionHumans.Parametr1).Replace(',', '.'), Convert.ToString(cr.DistributionHumans.Parametr2).Replace(',', '.')));

            return cr;
		}

		public void Update(CrossRoad cr)
		{
            ExecuteQuery(
               String.Format(
               "UPDATE `CrossRoad` SET `Name` = \"{1}\", `IsLights` = {2}, `LinesVertical`= {3}, `LinesHorisontal` = {4}, " +
               "`LinesRing` = {5}, `PriorityType` = {6}, `LightsTime` = {7} WHERE `ID` = {0};",
               cr.ID, cr.Name, (cr.IsLights) ? "1" : "0", cr.LinesVertical, cr.LinesHorisontal, cr.LinesRing, (int)cr.PriorityType, cr.LightsTime));

            //распределение машин
            ExecuteQuery(
                String.Format(
                "UPDATE `CrossRoadLaw` SET `IDLaw` = {0}, `Parametr1` = {1}, `Parametr2` = {2} " +
                "WHERE `IDCrossRoad` = {3} AND `LawOfWhat` = 1;",
                (int)cr.DistribustionCars.Type, Convert.ToString(cr.DistribustionCars.Parametr1).Replace(',', '.'), Convert.ToString(cr.DistribustionCars.Parametr2).Replace(',', '.'), cr.ID));

            //распределение пешеходов
            ExecuteQuery(
                String.Format(
                "UPDATE `CrossRoadLaw` SET `IDLaw` = {0}, `Parametr1` = {1}, `Parametr2` = {2} " +
                "WHERE `IDCrossRoad` = {3} AND `LawOfWhat` = 2;",
                (int)cr.DistributionHumans.Type, Convert.ToString(cr.DistributionHumans.Parametr1).Replace(',', '.'), Convert.ToString(cr.DistributionHumans.Parametr2).Replace(',', '.'), cr.ID));
		}

		public void Delete(CrossRoad cr)
		{
            int maxId = GetMaxID("CrossRoad");
            ExecuteQuery(
                String.Format(
                "DELETE FROM `CrossRoad` WHERE `ID` = {0}",
                cr.ID)
                );
            if (cr.ID != maxId)
                ExecuteQuery(
                    string.Format("UPDATE CrossRoad SET ID={0} WHERE ID={1}", cr.ID, maxId));
        }

		private List<CrossRoad> Select(String query)
		{
            var result = new List<CrossRoad>();
            var queryRows = ExecuteQuery(query);

            foreach (List<object> row in queryRows)
            {
                var cr = new CrossRoad();
                cr.ID = int.Parse(row[0].ToString());
                cr.Name = row[1].ToString();

                //булево значение наличия светофора
                int isLights = int.Parse(row[2].ToString());
                if (isLights == 1)
                    cr.IsLights = true;

                cr.LinesVertical = int.Parse(row[3].ToString());
                cr.LinesHorisontal = int.Parse(row[4].ToString());
                cr.LinesRing = int.Parse(row[5].ToString());
                cr.PriorityType = (PriorityTypes)int.Parse(row[6].ToString());
                cr.LightsTime = uint.Parse(row[7].ToString());

                //закон распределния машин
                var lawCarsQuery = ExecuteQuery(
                    "SELECT `IDLaw`, `Parametr1`, `Parametr2` FROM `CrossRoadLaw` "+
                    "WHERE `IDCrossRoad`="+cr.ID+" AND `LawOfWhat`=1");

                string tst;
                CrossRoadLaw crlCars = new CrossRoadLaw(
                    (DistrubutionLaws)int.Parse(tst = lawCarsQuery[0][0].ToString())
                    );
                crlCars.Parametr1 = double.Parse(lawCarsQuery[0][1].ToString());
                crlCars.Parametr2 = double.Parse(lawCarsQuery[0][2].ToString());
                cr.DistribustionCars = crlCars;

                //закон распределения пешеходов
                var lawHumansQuery = ExecuteQuery(
                   "SELECT `IDLaw`, `Parametr1`, `Parametr2` FROM `CrossRoadLaw` " +
                   "WHERE `IDCrossRoad`=" + cr.ID + " AND `LawOfWhat`=2");

                CrossRoadLaw crlHumans = new CrossRoadLaw(
                    (DistrubutionLaws)int.Parse(lawHumansQuery[0][0].ToString())
                    );
                crlHumans.Parametr1 = double.Parse(lawHumansQuery[0][1].ToString());
                crlHumans.Parametr2 = double.Parse(lawHumansQuery[0][2].ToString());
                cr.DistributionHumans = crlHumans;
                result.Add(cr);
            }
            return result;
        }

		public List<CrossRoad> SelectAll()
		{
            return Select("SELECT * FROM CrossRoad");
		}

        public CrossRoad SelectByID(int id)
        {
            return Select("SELECT * FROM CrossRoad WHERE ID = "+id).FirstOrDefault();
        }

		public CrossRoadDAO()
		{
		}

	}
}


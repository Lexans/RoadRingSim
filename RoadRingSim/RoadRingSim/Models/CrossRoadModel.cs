using RoadRingSim.Core.Domains;
using RoadRingSim.Data.DAO;
using System.Collections.Generic;
using System.Linq;

namespace RoadRingSim.Models
{
    public class CrossRoadModel
    {
        public CrossRoadDAO crossRoadDao = new CrossRoadDAO();
        public List<CrossRoad> CrossRoads { set; get; }

        public CrossRoadModel(CrossRoadDAO cr)
        {
            this.crossRoadDao = cr;
            CrossRoads = crossRoadDao.SelectAll();
        }

        public void AddCrossroad(CrossRoad cr)
        {
            CrossRoads.Add(crossRoadDao.Insert(cr));
        }
        public void EditCrossRoad(CrossRoad cr)
        {
            crossRoadDao.Update(cr);
            //CrossRoads.RemoveAll(x => x.ID == cr.ID);
            //CrossRoads.Add(cr);
        }
        public void DeleteCrossRoad(CrossRoad cr)
        {
            crossRoadDao.Delete(cr);
            CrossRoads.Remove(cr);
        }
    }
}

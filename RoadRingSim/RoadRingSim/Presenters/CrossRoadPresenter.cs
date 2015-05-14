using RoadRingSim.Core.Domains;
using RoadRingSim.Forms;
using RoadRingSim.Models;
using System;
using System.Windows.Forms;

namespace RoadRingSim.Presenters
{
    public class CrossRoadPresenter
    {
        private MainForm _form;
        private CrossRoadModel _model;

        //отсылает модель в форму
        public void Init(MainForm form, CrossRoadModel model)
        {
            _form = form;
            _model = model;
            form.ShowCrossRoadList(model.CrossRoads);
            form.AddItem += new Action(form_AddItem);
            form.DeleteItem += new Action<CrossRoad>(form_DeleteItem);
            form.EditItem += new Action<CrossRoad>(form_EditItem);
        }

        public void form_DeleteItem(CrossRoad obj)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранную модель перекрестка?", "Удаление перекрестка", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _model.DeleteCrossRoad(obj);
                _form.ShowCrossRoadList(_model.CrossRoads);
            }
        }

        public void form_AddItem()
        {
            var f = new FormCrossRoadAdd();
            if (f.ShowDialog() == DialogResult.OK)
            {
                _model.AddCrossroad(f.CrossRoad);
                _form.ShowCrossRoadList(_model.CrossRoads);
            }
        }
        public void form_EditItem(CrossRoad obj)
        {
            var f = new FormCrossRoadAdd(obj);
            if (f.ShowDialog() == DialogResult.OK)
            {
                _model.EditCrossRoad(f.CrossRoad);
                _form.ShowCrossRoadList(_model.CrossRoads);
            }
        }
    }
}
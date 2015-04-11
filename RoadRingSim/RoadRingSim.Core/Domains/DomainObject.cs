using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRingSim.Core.Domains
{

    /// <summary>
    /// абстрактный класс всех объектов модели
    /// </summary>
    public abstract class DomainObject
    {
        /// <summary>
        /// иднетификатор записи в базе данных
        /// </summary>
        public int ID { get; set; }
    }
}

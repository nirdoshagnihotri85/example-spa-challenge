using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPASample.DAO.Entities
{
    public class Screen
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ScreenSystem System { get; set; }
        public string Title { get; set; }
        public System.DateTime LastUpdate { get; set; }

        public virtual ICollection<Field> Field { get; set; }
    }
}
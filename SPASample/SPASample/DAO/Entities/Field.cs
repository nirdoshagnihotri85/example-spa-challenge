using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPASample.DAO.Entities
{
    public class Field
    {
        public int ID { get; set; }
        public int ScreenID { get; set; }
        public string Name { get; set; }
        public string Caption { get; set; }
        public FieldStatus Status { get; set; }
        public string Tooltip { get; set; }
        public DateTime LastUpdate { get; set; }
        public virtual Screen Screen { get; set; }
    }
}
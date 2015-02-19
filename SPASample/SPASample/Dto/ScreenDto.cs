using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPASample.Dto
{
    public class ScreenDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string System { get; set; }
        public string Title { get; set; }

        public List<FieldDto> Fields { get; set; }
    }
}
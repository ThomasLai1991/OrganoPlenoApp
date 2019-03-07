using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganoPlenoApp.Models
{
    public class Console
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Made { get; set; }

        public int OrganID { get; set; }
        public Organ Organ { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganoPlenoApp.Models
{
    public class Organ
    {
        public int ID { get; set; }
        public string Name { get; set; }

        //Division is the the grouping and location of actual pipes, such as GREAT, SWELL, CHOIR etc...
        public ICollection<Division> Divisions { get; set; }
        //The Control console where you sit and play music from.
        public ICollection<Console> Console { get; set; }
    }
}

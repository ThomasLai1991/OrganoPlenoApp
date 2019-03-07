using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OrganoPlenoApp.Models
{
    public class Division
    {
        public int ID { get; set; }

        [Display(Name = "Division")]
        public string Name { get; set; }
        // NumberOfStops is a calculated property.
        [Display(Name = "Stop Numbers")]
        public int? NumberOfStops { get { if (Pipes != null) { return Pipes.Count; } return null; } }

        public int OrganID { get; set; }
        public Organ Organ { get; set; }

        public ICollection<Pipe> Pipes { get; set; }

    }
}

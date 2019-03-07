using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using OrganoPlenoApp.Models.PipeEnumProperties;

namespace OrganoPlenoApp.Models
{
    public class Pipe
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }



        public string Name { get; set; }


        public Category Category { get; set; }
        public Specification Specification { get; set; }
        public Material Material { get; set; }

        public decimal Price { get; set; }
        //add annotation here to display year only


        [Display(Name = "Year of Make")]
        //[DatePickerType(DatePickerType)]
        public int Year { get; set; }

        //FK
        public int DivisionID { get; set; }
        public Division Division { get; set; }
    }
}

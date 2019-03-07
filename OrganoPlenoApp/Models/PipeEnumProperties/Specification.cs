using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OrganoPlenoApp.Models.PipeEnumProperties
{
    public enum Specification
    {
        [Display(Name = "32'")]
        ThirtyTwo,
        [Display(Name = "16'")]
        Sixteen,
        [Display(Name = "8'")]
        Eight,
        [Display(Name = "4'")]
        Four,
        [Display(Name = "2 2/3'")]
        TwoAndTwoThird,
        [Display(Name = "2'")]
        Two,
        [Display(Name = "1 3/5'")]
        OneAndThreeFifth,
        [Display(Name = "1 1/3'")]
        OneAndOneThird,
        [Display(Name = "III")]
        ThreeRanks,
        [Display(Name = "IV")]
        FourRanks,
        [Display(Name = "V")]
        FiveRanks
    }
}

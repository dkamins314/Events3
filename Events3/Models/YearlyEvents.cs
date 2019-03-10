using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Events3.Models.Enums;

namespace Events3.Models
{
    
    public class YearlyEvents
    {
        public YearlyEvents()
        {

        }

        [Key] public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{MM-dd-yyyy}")]
        [Display(Name = "Starting Date")]
        public DateTime StartingDate { get; set; }
        [Display(Name = "Starting Time")]
        public string StartTime { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{MM-dd-yyyy}")]
        [Display(Name = "Ending Date")]
        public DateTime EndingDate { get; set; }
        [Display(Name = "Ending Time")]
        public string EndTime { get; set; }
        public SpecialEvents SpecialEvents { get; set; }
        public SpecialShabassos SpecialShabassos { get; set; }
        public Months Months { get; set; }
        public Parshios Parshios { get; set; }
    }
}
    


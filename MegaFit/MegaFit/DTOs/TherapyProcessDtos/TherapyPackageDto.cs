using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.DTOs.TherapyProcessDtos
{
    public class TherapyPackageDto
    {
        public int Id { get; set; }
        public int Month { get; set; }
        public string TherapyName { get; set; }
        public string Package { get
            {
                return Month.ToString()+ " ay " +TherapyName ;
            } }
    }
}

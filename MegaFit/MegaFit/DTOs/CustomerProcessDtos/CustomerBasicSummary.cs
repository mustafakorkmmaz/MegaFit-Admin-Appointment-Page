using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.DTOs.CustomerProcessDtos
{
    public class CustomerBasicSummary
    {
        public int CustomerAssessmentId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; } 

        public string CustomerFullName
        {
            get
            {
                return CustomerName+ " " +CustomerSurname ;
            }
        }

    }
}

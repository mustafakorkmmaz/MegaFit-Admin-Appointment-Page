using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.DTOs.CustomerProcessDtos
{
    public class CustomerVisitDto
    {
        public string Complaint { get; set; }
        public bool IsSick { get; set; }
        public string Sick { get; set; } 
        public bool UsingDrugs { get; set; }
        public DateTime VisitDate { get; set; }
        public int CustomerId { get; set; }

    }
}

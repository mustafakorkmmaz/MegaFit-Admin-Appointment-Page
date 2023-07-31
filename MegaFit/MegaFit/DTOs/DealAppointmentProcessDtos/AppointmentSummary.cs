using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.DTOs.DealAppointmentProcessDtos
{
    public class AppointmentSummary
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }

        public string CustomerInfo { get
            {
                return CustomerName + " " + CustomerSurname+   "</br> "  + TherapyName ;
            }}
        public DateTime AppointmentDate { get; set; }
        public bool IsDone { get; set; }
        public string TherapyName { get; set; }
    }
}

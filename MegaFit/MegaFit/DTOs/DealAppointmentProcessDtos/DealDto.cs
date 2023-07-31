using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.DTOs.DealAppointmentProcessDtos
{
    public class DealDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        
        
        public int PackageId { get; set; }
        public int PackageDuration { get; set; }
        public int TotalSession { get {
                return PackageDuration * 8;
            }}
        public int AppointmentTimeId { get; set; }
        public int AppointmentHour { get; set; }
        
        public string AppointmentDayFirst { get; set; }
        public string AppointmentDaySecond { get; set; }

        public DateTime FirstAppointment { get; set; }


    }
}

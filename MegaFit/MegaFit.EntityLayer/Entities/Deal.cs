using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.EntityLayer.Entities
{
    public class Deal:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public CustomerAssessment CustomerAssessment { get; set; }
        public int PackageId { get; set; }
        public Package Package { get; set; }
        public int AppointmentTimeId { get; set; }
        public AppointmentTime AppointmentTime { get; set; }
        public int TotalSession {get; set; }
        public string AppointmentDayFirst { get; set; }
        public string AppointmentDaySecond { get; set; }


    }
}

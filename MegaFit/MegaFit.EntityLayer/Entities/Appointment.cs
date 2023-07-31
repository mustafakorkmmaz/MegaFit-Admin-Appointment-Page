using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.EntityLayer.Entities
{
    public class Appointment : IEntity
    {
        public int Id { get; set; }
        public int DealId { get; set; }     
        public Deal Deal { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime AppointmentDate { get; set; }
        
        
        
        
        
        

    }
}

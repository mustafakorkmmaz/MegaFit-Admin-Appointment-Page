using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.EntityLayer.Entities
{
    public class Package : IEntity
    {
        public int Id { get; set; }
        public int MonthCount { get; set; }
        public int TherapyId { get; set; }
        public Therapy Therapy { get; set;}
    }
}

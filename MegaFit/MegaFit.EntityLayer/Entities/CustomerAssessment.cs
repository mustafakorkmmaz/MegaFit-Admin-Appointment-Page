using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.EntityLayer.Entities
{
    public class CustomerAssessment :IEntity
    {
        public int Id { get; set; }
        public int VisitId { get; set; }
        public CustomerVisit CustomerVisit { get; set; }
        public string Evaluation { get;set; }
    }
}

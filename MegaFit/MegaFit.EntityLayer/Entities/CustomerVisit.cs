using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.EntityLayer.Entities
{
    public class CustomerVisit :IEntity
    {
        public int Id { get; set; }
        public string Complaint { get; set; }
        public bool IsSick { get; set; }
        public string? SicknessList { get; set; }
        public bool UsingDrugs { get; set; }
        public DateTime VisitDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


    }
}

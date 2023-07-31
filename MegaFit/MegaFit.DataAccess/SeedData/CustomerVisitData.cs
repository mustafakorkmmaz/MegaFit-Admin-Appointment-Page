using MegaFit.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.DataAccess.SeedData
{
    public class CustomerVisitData
    {
        public static readonly CustomerVisit CustomerVisitData_01 = new CustomerVisit()
        {
            Id = 1,
            Complaint="Şikayet",
            IsSick=true,
            UsingDrugs=true,
            VisitDate= DateTime.Now,
            CustomerId=1

        };
        public static readonly CustomerVisit CustomerVisitData_02 = new CustomerVisit()
        {
            Id = 2,
            Complaint = "Test",
            IsSick = false,
            UsingDrugs = false,
            VisitDate = DateTime.Now,
            CustomerId =2

        };
        public static readonly CustomerVisit CustomerVisitData_03 = new CustomerVisit()
        {
            Id = 3,
            Complaint = "Deneme",
            IsSick = true,
            UsingDrugs = false,
            VisitDate = DateTime.Now,
            CustomerId = 3

        };
    }
}

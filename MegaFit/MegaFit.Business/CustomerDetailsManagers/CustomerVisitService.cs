using MegaFit.DataAccess;
using MegaFit.DTOs.CustomerProcessDtos;
using MegaFit.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.Business.CustomerDetailsManagers
{
    public class CustomerVisitService : ICustomerVisitService
    {
        private readonly MegaContext _context;

        public CustomerVisitService(MegaContext context)
        {
            _context = context;
        }

        public int Create(CustomerVisitDto customerVisitDto)
        {
            var selmos = new CustomerVisit()
            {
                SicknessList=customerVisitDto.Sick,
                Complaint = customerVisitDto.Complaint,
                IsSick = customerVisitDto.IsSick,
                UsingDrugs=customerVisitDto.UsingDrugs,
                VisitDate = customerVisitDto.VisitDate,
                CustomerId = customerVisitDto.CustomerId,
                
            };
            _context.CustomerVisits.Add(selmos);
            _context.SaveChanges();
            return selmos.Id;
        }
    }
}

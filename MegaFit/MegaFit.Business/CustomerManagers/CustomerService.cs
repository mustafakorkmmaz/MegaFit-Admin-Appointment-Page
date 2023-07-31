using MegaFit.DataAccess;
using MegaFit.DTOs.CustomerProcessDtos;
using MegaFit.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.Business.CustomerManagers
{
    public class CustomerService : ICustomerService
    {
        private readonly MegaContext _context;

        public CustomerService(MegaContext context)
        {
            _context = context;
        }

        public int Create(CustomerDto dto)
        {
            var entity = new Customer()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                EmailAddress = dto.EmailAddress,
                Age = dto.Age,
                Height= dto.Height,
                Weight= dto.Weight,
                PhoneNumber = dto.PhoneNumber,
                IdentityNumber = dto.IdentityNumber,
                CustomerAddress = dto.CustomerAddress,
            };
            _context.Customers.Add(entity);
            _context.SaveChanges();
            return entity.Id;
                

        }
    }
}

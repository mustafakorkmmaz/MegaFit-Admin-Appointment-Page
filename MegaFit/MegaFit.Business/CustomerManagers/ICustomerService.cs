using MegaFit.DTOs.CustomerProcessDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.Business.CustomerManagers
{
    public interface ICustomerService
    {
        int Create(CustomerDto dto);
    }
}

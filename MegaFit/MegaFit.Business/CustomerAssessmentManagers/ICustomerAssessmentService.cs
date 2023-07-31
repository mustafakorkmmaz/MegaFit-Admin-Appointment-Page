using MegaFit.DTOs.CustomerProcessDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.Business.CustomerHistoryManagers
{
    public interface ICustomerAssessmentService
    {
        int Create(CustomerAssessmentDto dto);
        IEnumerable<CustomerMegaSummary> GetAllInfos();
        IEnumerable<CustomerBasicSummary> GetBasicInfos();
        CustomerMegaSummary GetDetails(int id);

    }
}

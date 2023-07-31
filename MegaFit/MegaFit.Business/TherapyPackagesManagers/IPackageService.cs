
using MegaFit.DTOs.TherapyProcessDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.Business.TherapyPackagesManagers
{
    public interface IPackageService
    {
        IEnumerable<TherapyPackageDto> GetAll();
        ProcessMessage AddNewTherapy(TherapyDto newTherapy);
    }
}

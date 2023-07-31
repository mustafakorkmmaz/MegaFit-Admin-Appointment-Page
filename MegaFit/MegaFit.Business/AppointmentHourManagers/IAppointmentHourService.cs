using MegaFit.DTOs.AppointmentHourProcessDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.Business.AppointmentHourManagers
{
    public interface IAppointmentHourService
    {
        AppointmentHourDto GetById(int id);
        IEnumerable<AppointmentHourDto> GetAll();
    }
}

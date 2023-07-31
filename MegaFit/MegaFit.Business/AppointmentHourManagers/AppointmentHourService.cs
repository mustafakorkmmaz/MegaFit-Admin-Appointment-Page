using MegaFit.DataAccess;
using MegaFit.DTOs.AppointmentHourProcessDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.Business.AppointmentHourManagers
{
    public class AppointmentHourService : IAppointmentHourService
    {
        private readonly MegaContext _megaContext;

        public AppointmentHourService(MegaContext megaContext)
        {
            _megaContext = megaContext;
        }

        public IEnumerable<AppointmentHourDto> GetAll()
        {
            return _megaContext.AppointmentTimes.Select(t => new AppointmentHourDto()
            {
                Id = t.Id,
                Hour = t.AppointmentHour
            }).ToList();
        }

        public AppointmentHourDto GetById(int id)
        {
            if (id != 0) 
            {
                return _megaContext.AppointmentTimes.Where(t => t.Id == id).Select(t => new AppointmentHourDto()
                {
                    Id = t.Id,
                    Hour = t.AppointmentHour
                }).FirstOrDefault();
            }
            else return new AppointmentHourDto();
            
            
        }
    }
}

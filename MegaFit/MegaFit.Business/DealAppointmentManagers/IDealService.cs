using MegaFit.DTOs.DealAppointmentProcessDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.Business.DealAppointmentManagers
{
    public interface IDealService
    {
        ProcessMessage DealDone(DealDto deal);

        IEnumerable<AppointmentSummary> GetAppointmentSummaries();

        ProcessMessage GetCompleted(int appointmentId);
        ProcessMessage Delete(int id);

    }
}

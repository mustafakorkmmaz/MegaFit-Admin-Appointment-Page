using MegaFit.DataAccess;
using MegaFit.DTOs.DealAppointmentProcessDtos;
using MegaFit.EntityLayer;
using MegaFit.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.Business.DealAppointmentManagers
{
    public class DealService : IDealService
    {
        private readonly MegaContext _megaContext;

        public DealService(MegaContext megaContext)
        {
            _megaContext = megaContext;
        }

        public ProcessMessage DealDone(DealDto deal)
        {

            deal.PackageDuration = _megaContext.Packages.Find(deal.PackageId).MonthCount;
            var firstDay = TurkishDayToEnglish(deal.AppointmentDayFirst);
            var secondDay = TurkishDayToEnglish(deal.AppointmentDaySecond);
            var existingDealCount = _megaContext.Deals
                .Count(d => d.AppointmentTimeId == deal.AppointmentTimeId &&
                            d.AppointmentDayFirst == firstDay &&
                            d.AppointmentDaySecond == secondDay);
            if (existingDealCount == 0) 
            {
                try
                {


                    var entity = new Deal()
                    {
                        CustomerId = deal.CustomerId,
                        PackageId = deal.PackageId,
                        TotalSession = deal.TotalSession,
                        AppointmentTimeId = deal.AppointmentTimeId,
                        AppointmentDayFirst = firstDay,
                        AppointmentDaySecond = secondDay,

                    };


                    _megaContext.Deals.Add(entity);
                    _megaContext.SaveChanges();

                    DateTime tarih = deal.FirstAppointment;
                    int seansSayisi = 0;
                    var appointmentHour = _megaContext.AppointmentTimes.FirstOrDefault(x => x.Id == entity.AppointmentTimeId).AppointmentHour;

                    while (seansSayisi < deal.TotalSession)
                    {
                        DateTime randevuGun1 = GetNextWeekdayWithTime(tarih, entity.AppointmentDayFirst, new TimeSpan(appointmentHour, 0, 0));
                        DateTime randevuGun2 = GetNextWeekdayWithTime(randevuGun1.AddDays(1), entity.AppointmentDaySecond, new TimeSpan(appointmentHour, 0, 0));

                        var appointmentFirst = new Appointment()
                        {
                            DealId = entity.Id,
                            IsCompleted = false,
                            AppointmentDate = randevuGun1,
                        };

                        _megaContext.Appointments.Add(appointmentFirst);
                        _megaContext.SaveChanges();

                        var appointmentSecond = new Appointment()
                        {
                            DealId = entity.Id,
                            IsCompleted = false,
                            AppointmentDate = randevuGun2,
                        };
                        _megaContext.Appointments.Add(appointmentSecond);
                        _megaContext.SaveChanges();
                        seansSayisi += 2;

                        tarih = randevuGun2.AddDays(3);

                    }
                    return ProcessMessage.Success("Anlaşma başarıyla kaydedildi");
                }
                catch (Exception ex)
                {
                    Trace.TraceError(ex.ToString());
                    return ProcessMessage.Failure();
                }
            }
            else
            {
                return ProcessMessage.Failure();
            }

            
           

           
        }

        public static DateTime GetNextWeekdayWithTime(DateTime startDate, string day, TimeSpan desiredTime)
        {
            DayOfWeek desiredDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day, true);
            DateTime nextDate = startDate.Date;

           
            while (nextDate.DayOfWeek != desiredDay)
            {
                nextDate = nextDate.AddDays(1);
            }

            nextDate = nextDate.Date + desiredTime;

           
            if (nextDate < startDate)
            {
                nextDate = nextDate.AddDays(7);
            }

            return nextDate;
        }

        public IEnumerable<AppointmentSummary> GetAppointmentSummaries()
        {
            try
            {
                return _megaContext.Appointments.Select(appo=>new AppointmentSummary()
                {
                    Id = appo.Id,
                    CustomerName =appo.Deal.CustomerAssessment.CustomerVisit.Customer.FirstName,
                    CustomerSurname = appo.Deal.CustomerAssessment.CustomerVisit.Customer.LastName,
                    AppointmentDate =appo.AppointmentDate,
                    IsDone =appo.IsCompleted,
                    TherapyName=appo.Deal.Package.Therapy.Name,
                }).ToList();
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return Enumerable.Empty<AppointmentSummary>();
                
            }
        }

        public ProcessMessage GetCompleted(int appointmentId)
        {
            try
            {
                var findedAppointment = _megaContext.Appointments.FirstOrDefault(x => x.Id == appointmentId);

                findedAppointment.IsCompleted = true;
                _megaContext.SaveChanges();
                return ProcessMessage.Success();
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return ProcessMessage.Failure();

            }

        }
        public string TurkishDayToEnglish(string turkishDay)
        {
            CultureInfo culture = new CultureInfo("tr-TR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;

            DayOfWeek dayOfWeek = (DayOfWeek)dtfi.DayNames.ToList().IndexOf(turkishDay);

            return dayOfWeek.ToString();
        }

        public ProcessMessage Delete(int id)
        {
            try
            {
                var customerDeal = _megaContext.Deals.Where(x => x.CustomerId == id).FirstOrDefault();
                var customerAppointments = _megaContext.Appointments.Where(x=>x.DealId==customerDeal.Id).ToList();
                foreach (var customer in customerAppointments)
                {
                    _megaContext.Appointments.Remove(customer);
                }
                _megaContext.Deals.Remove(customerDeal);
                var customerAssesment = _megaContext.CustomerAssessments.Where(x => x.Id == id).FirstOrDefault();
                _megaContext.CustomerAssessments.Remove(customerAssesment);
                var customerVisit = _megaContext.CustomerVisits.Where(x => x.Id == customerAssesment.VisitId).FirstOrDefault();
                _megaContext.CustomerVisits.Remove(customerVisit);
                var customerFirst = _megaContext.Customers.Where(x => x.Id == customerVisit.CustomerId).FirstOrDefault();
                _megaContext.Customers.Remove(customerFirst);
                _megaContext.SaveChanges();
                return ProcessMessage.Success("Tüm Silme işlemleri başarılı");
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return ProcessMessage.Failure();
            }
        }
    }
}

                









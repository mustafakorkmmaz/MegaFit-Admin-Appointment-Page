using MegaFit.DataAccess;
using MegaFit.DTOs.TherapyProcessDtos;
using MegaFit.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.Business.TherapyPackagesManagers
{
    public class PackageService : IPackageService
    {
        private readonly MegaContext _megaContext;

        public PackageService(MegaContext megaContext)
        {
            _megaContext = megaContext;
        }

        public ProcessMessage AddNewTherapy(TherapyDto newTherapy)
        {
            try
            {
                var therapy = new Therapy()
                {
                    Name = newTherapy.TherapyName
                };
                _megaContext.Therapies.Add(therapy);
                _megaContext.SaveChanges();

                var therpyPackageF = new Package()
                {
                    MonthCount = 1,
                    TherapyId = therapy.Id
                };
                _megaContext.Packages.Add(therpyPackageF);
                var therpyPackageS = new Package()
                {
                    MonthCount = 2,
                    TherapyId = therapy.Id
                };
                _megaContext.Packages.Add(therpyPackageS);
                var therpyPackageT = new Package()
                {
                    MonthCount = 3,
                    TherapyId = therapy.Id
                };
                _megaContext.Packages.Add(therpyPackageT);
                _megaContext.SaveChanges();

                return ProcessMessage.Success("Tedaviler Paketler ile birlikte başarıyla eklendi");

            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return ProcessMessage.Failure();
                
            }
        }

        public IEnumerable<TherapyPackageDto> GetAll()
        {
            try
            {
                return _megaContext.Packages.Select(x => new TherapyPackageDto()
                {
                    Id = x.Id,
                    Month = x.MonthCount,
                    TherapyName = x.Therapy.Name,
                }).ToList();
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return Enumerable.Empty<TherapyPackageDto>();
                
            }
        }
    }
}

using MegaFit.Business.CustomerHistoryManagers;
using MegaFit.DataAccess;
using MegaFit.DTOs.CustomerProcessDtos;
using MegaFit.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.Business.CustomerAssessmentManagers
{
    public class CustomerAssessmentService : ICustomerAssessmentService
    {
        private readonly MegaContext _context;

        public CustomerAssessmentService(MegaContext context)
        {
            _context = context;
        }

        public int Create(CustomerAssessmentDto dto)
        {
            var cA = new CustomerAssessment()
            {
                VisitId = dto.VisitId,
                Evaluation = dto.Evaluation,
            };
            _context.CustomerAssessments.Add(cA);
            _context.SaveChanges();
            return cA.Id;
        }

        public IEnumerable<CustomerMegaSummary> GetAllInfos()
        {
            try
            {
                return _context.CustomerAssessments
                    .Select(c => new CustomerMegaSummary()
                    {
                        CustomerAssessmentId = c.Id,
                        CustomerName=c.CustomerVisit.Customer.FirstName,
                        CustomerSurname=c.CustomerVisit.Customer.LastName,
                        CustomerAge=c.CustomerVisit.Customer.Age,
                        CustomerHeigth=c.CustomerVisit.Customer.Height,
                        CustomerWeight=c.CustomerVisit.Customer.Weight,
                        CustomerEmailAddress=c.CustomerVisit.Customer.EmailAddress,
                        CustomerPhoneNumber=c.CustomerVisit.Customer.PhoneNumber,
                        CustomerAddress=c.CustomerVisit.Customer.CustomerAddress,
                        CustomerIdentityNumber=c.CustomerVisit.Customer.IdentityNumber,
                        CustomerComplaint=c.CustomerVisit.Complaint,
                        UsingDrugs=c.CustomerVisit.UsingDrugs,
                        CustomerFirstVisit=c.CustomerVisit.VisitDate,
                        CustomerEvaulation=c.Evaluation,
                        CustomerSicknesses=c.CustomerVisit.SicknessList,
                    }).ToList();
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return Enumerable.Empty<CustomerMegaSummary>();
                
            }
        }

        public IEnumerable<CustomerBasicSummary> GetBasicInfos()
        {
            return _context.CustomerAssessments.Select(c => new CustomerBasicSummary()
            {
                CustomerAssessmentId=c.Id,
                CustomerName=c.CustomerVisit.Customer.FirstName,
                CustomerSurname=c.CustomerVisit.Customer.LastName,
            }).ToList();
        }

        public CustomerMegaSummary GetDetails(int id)
        {
            
            try
            {
                return _context.CustomerAssessments.Where(c => c.Id == id).Select(c => new CustomerMegaSummary()
                {
                    CustomerAssessmentId = c.Id,
                    CustomerName = c.CustomerVisit.Customer.FirstName,
                    CustomerSurname = c.CustomerVisit.Customer.LastName,
                    CustomerAge = c.CustomerVisit.Customer.Age,
                    CustomerHeigth = c.CustomerVisit.Customer.Height,
                    CustomerWeight = c.CustomerVisit.Customer.Weight,
                    CustomerEmailAddress = c.CustomerVisit.Customer.EmailAddress,
                    CustomerPhoneNumber = c.CustomerVisit.Customer.PhoneNumber,
                    CustomerAddress = c.CustomerVisit.Customer.CustomerAddress,
                    CustomerIdentityNumber = c.CustomerVisit.Customer.IdentityNumber,
                    CustomerComplaint = c.CustomerVisit.Complaint,
                    UsingDrugs = c.CustomerVisit.UsingDrugs,
                    CustomerFirstVisit = c.CustomerVisit.VisitDate,
                    CustomerEvaulation = c.Evaluation,
                    CustomerSicknesses = c.CustomerVisit.SicknessList,
                }).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return new CustomerMegaSummary();
            }
        }
    }
}

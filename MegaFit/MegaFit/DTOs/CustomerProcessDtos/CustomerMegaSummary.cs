using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.DTOs.CustomerProcessDtos
{
    public class CustomerMegaSummary
    {
        public int CustomerAssessmentId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public int CustomerAge { get; set; }
        public int CustomerHeigth { get; set; }
        public int CustomerWeight { get; set;}
        public string CustomerIdentityNumber { get; set; }
        public string CustomerEmailAddress { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerComplaint { get; set; }
        public string CustomerSicknesses{get; set; }
        public bool UsingDrugs { get; set; }
        public DateTime CustomerFirstVisit { get;set; }
        public string CustomerEvaulation { get;set; }
        public string HasUsingDrugs => UsingDrugs ? "Var" : "Yok"; //Sadece arrow function varsa readonlydir...



    }
}

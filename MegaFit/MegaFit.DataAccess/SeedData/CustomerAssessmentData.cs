using MegaFit.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.DataAccess.SeedData
{
    public class CustomerAssessmentData
    {
        public static readonly CustomerAssessment CustomerAssessment_01 = new CustomerAssessment()
        {
            Id=1,
            Evaluation="Deneme",
            VisitId=1
        };
        public static readonly CustomerAssessment CustomerAssessment_02 = new CustomerAssessment()
        {
            Id = 2,
            Evaluation = "Deneme",
            VisitId = 2,

        };
        public static readonly CustomerAssessment CustomerAssessment_03 = new CustomerAssessment()
        {
            Id = 3,
            Evaluation = "Deneme",
            VisitId = 3
        };
        
    }
}

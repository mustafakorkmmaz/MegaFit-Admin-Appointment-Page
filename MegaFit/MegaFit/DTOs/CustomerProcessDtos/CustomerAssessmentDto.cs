using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.DTOs.CustomerProcessDtos
{
    public class CustomerAssessmentDto
    {
        public int Id { get; set; }
        public int VisitId { get; set; }
        public string Evaluation { get; set; }

    }
}

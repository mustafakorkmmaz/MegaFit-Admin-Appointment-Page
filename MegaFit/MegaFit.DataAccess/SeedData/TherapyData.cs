using MegaFit.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.DataAccess.SeedData
{
    public class TherapyData
    {
        public static readonly Therapy Therapy_01 = new Therapy()
        {
            Id = 1,
            Name = "GTOS",
        };
        public static readonly Therapy Therapy_02 = new Therapy()
        {
            Id = 2,
            Name = "Pilates",
        };
        public static readonly Therapy Therapy_03 = new Therapy()
        {
            Id = 3,
            Name = "Fizik Tedavi",
        };
       
    }
}

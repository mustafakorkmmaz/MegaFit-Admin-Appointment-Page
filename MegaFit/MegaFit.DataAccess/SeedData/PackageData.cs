using MegaFit.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.DataAccess.SeedData
{
    public class PackageData
    {
        public static readonly Package Package_01 = new Package()
        {
            Id=1,
            MonthCount=1,
            TherapyId=TherapyData.Therapy_01.Id
        };
        public static readonly Package Package_02 = new Package()
        {
            Id = 2,
            MonthCount = 2,
            TherapyId = TherapyData.Therapy_01.Id
        };
        public static readonly Package Package_03 = new Package()
        {
            Id = 3,
            MonthCount = 3,
            TherapyId = TherapyData.Therapy_01.Id
        };
        public static readonly Package Package_04 = new Package()
        {
            Id = 4,
            MonthCount = 1,
            TherapyId = TherapyData.Therapy_02.Id
        };
        public static readonly Package Package_05 = new Package()
        {
            Id = 5,
            MonthCount = 2,
            TherapyId = TherapyData.Therapy_02.Id
        };
        public static readonly Package Package_06 = new Package()
        {
            Id = 6,
            MonthCount = 3,
            TherapyId = TherapyData.Therapy_02.Id
        };
        public static readonly Package Package_07 = new Package()
        {
            Id = 7,
            MonthCount = 1,
            TherapyId = TherapyData.Therapy_03.Id
        };
        public static readonly Package Package_08 = new Package()
        {
            Id = 8,
            MonthCount = 2,
            TherapyId = TherapyData.Therapy_03.Id
        };
        public static readonly Package Package_09 = new Package()
        {
            Id = 9,
            MonthCount = 3,
            TherapyId = TherapyData.Therapy_03.Id
        };
    }
}

using MegaFit.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.DataAccess.SeedData
{
    public class CustomerData
    {
        public static readonly Customer Customer_01 = new Customer()
        {
            Id = 1,
            FirstName = "Mustafa",
            LastName = "Korkmaz",
            IdentityNumber = "11102613645",
            EmailAddress = "mustafakorkmmaz@gmail.com",
            PhoneNumber = "05343494123",
            CustomerAddress="Uskudar"
        };
        public static readonly Customer Customer_02 = new Customer()
        {
            Id = 2,
            FirstName = "Mesut Rıza",
            LastName = "Tunur",
            IdentityNumber = "313569752136",
            EmailAddress = "mesutrizatunur@gmail.com",
            PhoneNumber = "05343494122",
            CustomerAddress = "Kartal"
        };
        public static readonly Customer Customer_03 = new Customer()
        {
            Id = 3,
            FirstName = "Yunus",
            LastName = "Akbulut",
            IdentityNumber = "22269813645",
            EmailAddress = "yunusakbulut@gmail.com",
            PhoneNumber = "05343494121",
            CustomerAddress = "Maltepe"
        };
    }
}

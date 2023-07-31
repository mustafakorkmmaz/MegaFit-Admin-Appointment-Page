using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.EntityLayer.Entities
{
    public class Therapy :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

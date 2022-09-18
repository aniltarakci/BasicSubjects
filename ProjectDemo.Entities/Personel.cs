using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.Entities
{
    public class Personel : IEntity
    {
        public int Id { get; set; }
        public string SoyAd { get; set; }
        public string Ad { get; set; }
    }
}

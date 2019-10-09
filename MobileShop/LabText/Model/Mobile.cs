using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabText.Model
{
   public class Mobile
    {
        public int Id { set; get;}
        public string Name { set; get; }
        public string IMEI { set; get; }
        public int Price { set; get; }
        public int PriceFrom { set; get; }
        public int PriceTo { set; get; }

    }
}

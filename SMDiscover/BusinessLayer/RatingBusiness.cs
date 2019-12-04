using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Rating
    {
        public int UserId { get; set; }
        public int ShopId { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; }
    }
}

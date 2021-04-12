using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerShopBlazor.Data
{
    public class Bill
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}

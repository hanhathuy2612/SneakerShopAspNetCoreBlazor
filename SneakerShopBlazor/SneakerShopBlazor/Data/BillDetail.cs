using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerShopBlazor.Data
{
    public class BillDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal IntoMoney { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int BillId { get; set; }
        public Bill Bill { get; set; }
    }
}

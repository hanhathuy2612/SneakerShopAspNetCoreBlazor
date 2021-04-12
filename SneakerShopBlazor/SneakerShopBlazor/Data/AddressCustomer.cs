using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerShopBlazor.Data
{
    public class AddressCustomer
    {
        public int Id { get; set; }
        public string AddressName{ get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}

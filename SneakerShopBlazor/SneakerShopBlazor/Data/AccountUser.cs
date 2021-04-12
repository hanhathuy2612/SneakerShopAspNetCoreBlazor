using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerShopBlazor.Data
{
    public class AccountUser
    {
        public int Id { get; set; }
        public string Useraname { get; set; }
        public string Password{ get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}

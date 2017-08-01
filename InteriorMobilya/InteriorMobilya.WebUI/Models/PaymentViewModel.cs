using InteriorMobilya.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorMobilya.WebUI.Models
{
    public class PaymentViewModel
    {
        public ICollection<CustomerAdress> CustomerAdresses { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}

using InteriorMobilya.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorMobilya.WebUI.Entities
{
    
    public class CustomIdentityUser : IdentityUser<Guid>
    {
       
        
       public virtual ICollection<Customer> Customers { get; set; }
    } 
}

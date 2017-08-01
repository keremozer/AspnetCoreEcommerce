using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorMobilya.WebUI.Entities
{
    public class CustomIdentityRole :IdentityRole<Guid>
    {
    }
}

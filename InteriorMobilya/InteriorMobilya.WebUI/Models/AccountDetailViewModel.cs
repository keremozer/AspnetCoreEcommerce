using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorMobilya.WebUI.Models
{
    public class AccountDetailViewModel
    {
        
        [Required(ErrorMessage ="* Lütfen kullanıcı adı giriniz!")]
       
        public string UserName { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public Nullable<DateTime> BirthDate { get; set; }
        
        public Nullable<bool> Gender { get; set; }
        [MaxLength(11)]
        public string Phone { get; set; }


    }
    
}

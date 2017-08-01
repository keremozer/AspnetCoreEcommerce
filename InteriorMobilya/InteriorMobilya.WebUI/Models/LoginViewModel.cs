using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorMobilya.WebUI.Models
{
    public class LoginViewModel
    {
        public Guid UserID { get; set; }
        [Required(ErrorMessage ="* Lütfen email adresi giriniz!")]
        [DataType(DataType.EmailAddress,ErrorMessage ="* Lütfen doğru bir email adresi giriniz!")]
         
        public string Email { get; set; }
        [Required(ErrorMessage ="* Lütfen şifrenizi giriniz!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorMobilya.WebUI.Models
{
    public class RegisterViewModel
    {
        [MaxLength(150,ErrorMessage ="* Kullanıcı adınız fazla uzun!")]
        [Required(ErrorMessage ="* Lütfen bir kullanıcı adı giriniz!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "* Lütfen email adresi giriniz!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "* Lütfen doğru bir email adresi giriniz!")]

        public string Email { get; set; }
        [Required(ErrorMessage = "* Lütfen şifrenizi giriniz!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "* Lütfen şifrenizi tekrar giriniz!")]
        [Compare("Password", ErrorMessage = "* Şifreler uyuşmamaktadır!")]
        public string ConfirmPassword { get; set; }
    }
}

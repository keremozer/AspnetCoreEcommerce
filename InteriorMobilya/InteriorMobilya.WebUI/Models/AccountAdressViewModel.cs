using InteriorMobilya.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorMobilya.WebUI.Models
{
    public class AccountAdressViewModel
    {
        [MaxLength(500)]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "* Lütfen adres giriniz!")]
        public string AdressDescription { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "* Lütfen ad soyad giriniz!")]
        public string Name { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "* Lütfen adres tanımı giriniz!")]
        public string AdressTitle { get; set; }

        [Required(ErrorMessage ="* Lütfen bir şehir seçiniz!")]
        public int? CityID { get; set; }

        [MaxLength(15)]
        [Required(ErrorMessage = "* Lütfen telefon giriniz!")]
        public string Phone { get; set; }
    }
}

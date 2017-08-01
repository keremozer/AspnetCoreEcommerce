using InteriorMobilya.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InteriorMobilya.Model
{
    [Table("Cities")]
    public class City : IEntity
    {
        //PK
        public int CityID { get; set; }
        //FK
        public int CountryID { get; set; }
        //Prop
        public string CityName { get; set; }

        //Navi
        public virtual Country Country { get; set; }
     
    }
}

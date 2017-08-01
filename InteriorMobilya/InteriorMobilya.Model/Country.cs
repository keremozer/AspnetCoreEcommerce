using InteriorMobilya.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InteriorMobilya.Model
{
    [Table("Countries")]
    public class Country : IEntity
    {
        //PK
        public int CountryID { get; set; }
        //Prop
        public string CountryName { get; set; }
        //Navi
        public virtual ICollection<City> Cities { get; set; }
    }
}

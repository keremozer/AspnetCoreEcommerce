using InteriorMobilya.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InteriorMobilya.Model
{
    [Table("Categories")]
    public class Category : IEntity
    {
        //PK
        public int CategoryID { get; set; }
        //FK
        //Prop
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }

        //Navi
        public virtual ICollection<Product> Products { get; set; }


    }
}

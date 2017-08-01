using InteriorMobilya.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InteriorMobilya.Model
{
    [Table("CustomerAdresses")]
    public class CustomerAdress : IEntity
    {
        //PK
        public int CustomerAdressID { get; set; }
        //FK
        public int CustomerID { get; set; }
        public int CityID { get; set; }
        //Prop
        public string AdressTitle { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string AdressDescription { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }

        //NaviProp
        public virtual City City { get; set; }
        public virtual Customer Customer { get; set; }

    }
}

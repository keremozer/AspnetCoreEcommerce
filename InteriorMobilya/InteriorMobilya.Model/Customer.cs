using InteriorMobilya.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InteriorMobilya.Model
{
    [Table("Customers")]
    public class Customer : IEntity
    {
        //PK
        public int CustomerID { get; set; }
        //FK
        public Guid UserID { get; set; }
        //Prop
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<DateTime> CreatedDate { get; set; }
        public Nullable<DateTime> BirthDate { get; set; }
        public string Phone { get; set; }
        public Nullable<bool> Gender { get; set; }
        public bool IsActive { get; set; }

        
    }
}

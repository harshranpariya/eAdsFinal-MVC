using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eAdsFInalMVC.Models
{
    [Table("product")]
    public class product
    {
        [Key]
         public int pId { get; set; }
            public string pName { get; set; }
            public string pCategory { get; set; }

            public string pDescription { get; set; }

            public Decimal pPrice { get; set; }

        public int ownerid { get; set; }
        public Boolean? status { get; set; }
        }
}
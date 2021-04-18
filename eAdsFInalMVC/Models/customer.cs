using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eAdsFInalMVC.Models
{
    [Table("customer")]

    public class customer
    {
        public int Id { get; set; }
        public string cName { get; set; }
        public string cEmail { get; set; }

        public string cAddress { get; set; }
        public string cCity { get; set; }

        public string cZip { get; set; }

        public string cProvince { get; set; }



        public string cCountry { get; set; }

        public string cPassword { get; set; }

        public Boolean status { get; set; }

        public DateTime? createdDate { get; set; }
    }
}
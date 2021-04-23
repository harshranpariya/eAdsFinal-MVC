using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eAdsFInalMVC.Models
{
    [Table("customer1")]

    public class customer1
    {
        public customer1(string id , string cEmail)
        {
            Id = id;
             
            this.cEmail = cEmail;
        }

        public customer1()
        {
        }

        //public customer1(string id, string cEmail = " ", string cName=" ",  string cAddress=" ", string cCity = " ", string cZip = " ", string cProvince = " ", string cCountry = " " )
        //{
        //    Id = id;
        //    this.cName = cName;
        //    this.cEmail = cEmail;
        //    this.cAddress = cAddress;
        //    this.cCity = cCity;
        //    this.cZip = cZip;
        //    this.cProvince = cProvince;
        //    this.cCountry = cCountry;


        //}

        public string Id { get; set; }
        public string cName { get; set; }
        public string cEmail { get; set; }

        public string cAddress { get; set; }
        public string cCity { get; set; }

        public string cZip { get; set; }

        public string cProvince { get; set; }



        public string cCountry { get; set; }  

 
        public Boolean status { get; set; }

 

       
        
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace yeni.Models
{
    public class Class1
    {
        //[NotMapped]
        //public HttpPostedFileBase File { get; set; }

        public int id { get; set; }

        public string adi { get; set; }

        public string soyadi { get; set; }

        public string name { get; set; }

        public string password { get; set; }

        


    }
}
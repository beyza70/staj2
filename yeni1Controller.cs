using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using yeni.Models;
using System.Web.UI.WebControls;
using System.Drawing;
using DAL;
//using Class1 = DAL.Class1;
using Class1 = yeni.Models.Class1;
using System.Threading.Tasks;


//Video izlencek , anasayfaya baslancak, staj defteri doldurulcak



namespace yeni.Controllers
{
    [RoutePrefix("api/yeni1")]
    public class yeni1Controller : ApiController
    {


        [HttpPost]
        [Route("Registration")]
        public string Registration(Class1 class1)
        {
            string msg = string.Empty;


            ReactProjesiEntities db = new ReactProjesiEntities();
            yonetici yon = new yonetici();

            yon.yonetici_adi = class1.adi;
            yon.yonetici_soyadi = class1.soyadi;
            yon.yonetici_kullanici_adi = class1.name;
            yon.yonetici_sifre = class1.password;

            // yonetici yoneticiObj = db.yonetici.SingleOrDefault(m => m.yonetici_kullanici_adi == class1.name && m.yonetici_sifre == class1.password && m.yonetici_adi == class1.adi && m.yonetici_soyadi == class1.soyadi);
            db.yonetici.Add(yon);
            db.SaveChanges();



            return msg;
        }

        //[HttpPost]
        //[Route("Registration")]
        //public string Registration(yonetici yon)
        //{
        //    string msg = string.Empty;

        //    ReactProjesiEntities db = new ReactProjesiEntities();


        //    // yonetici yoneticiObj = db.yonetici.SingleOrDefault(m => m.yonetici_kullanici_adi == class1.name && m.yonetici_sifre == class1.password && m.yonetici_adi == class1.adi && m.yonetici_soyadi == class1.soyadi);
        //    db.yonetici.Add(yon);
        //    db.SaveChanges();



        //    return msg;
        //}

        [HttpPost]
        [Route("Login")]
        public string Login(Class1 class1)
        {
            string msg = string.Empty;

            ReactProjesiEntities db = new ReactProjesiEntities();
            yonetici yoneticiObj = db.yonetici.Where(m => m.yonetici_kullanici_adi == class1.name && m.yonetici_sifre == class1.password).SingleOrDefault();



            if (yoneticiObj != null)
            {
                msg = "Giris Basarili";

            }
            else
            {
                msg = "Giris Hatali";
            }
            


            return msg;
        }
    }
}


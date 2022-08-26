using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Management;

using System.Diagnostics;
using System.Deployment.Application;
using System.Collections;

using System.IO;

using System.Reflection;
using Microsoft.Win32;


namespace ip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            string mac = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {

                if (nic.OperationalStatus == OperationalStatus.Up && (!nic.Description.Contains("Virtual") && !nic.Description.Contains("Pseudo")))
                {
                    if (nic.GetPhysicalAddress().ToString() != "")
                    {
                        mac = nic.GetPhysicalAddress().ToString();
                    }
                }
            }

            string ram = "";
            ManagementObjectSearcher Search = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");

            foreach (ManagementObject Mobject in Search.Get())
            {
                double Ram_Bytes = (Convert.ToDouble(Mobject["TotalPhysicalMemory"]));
                double ramgb = Ram_Bytes / 1073741824;
                double islem = Math.Ceiling(ramgb);
                ram = islem.ToString() + " GB";
            }


            string islemci = string.Empty;
            ManagementObjectSearcher mos =new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            
            foreach (ManagementObject mo in mos.Get())
            {
                islemci = (string)mo["Name"];
            }


            string bilgisayarAdi = Dns.GetHostName();
            textBox_adi.Text = bilgisayarAdi;
            string ipAdresi = Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString();
            textBox_ip.Text = ipAdresi;
            textBox_mac.Text = mac;
            textBox_ram.Text = ram;
            textBox_islemci.Text = islemci;
            timer1.Start();
            textBox_giris.Text = DateTime.Now.ToString();



            SqlConnection baglanti = new SqlConnection("Data Source=BEYZA;Initial Catalog=ip_adresi;Integrated Security=True");
            
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
                
            string kayit = "insert into bilgiler4(bilgisayar_adi,ip_adresi,giris_saati,mac_adresi,islemci,ram) values (@adi,@ip,@giris,@mac,@islemci,@ram)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
               
            komut.Parameters.AddWithValue("@adi", textBox_adi.Text);
            komut.Parameters.AddWithValue("@ip", textBox_ip.Text);
            komut.Parameters.AddWithValue("@giris", textBox_giris.Text);
            komut.Parameters.AddWithValue("@mac", textBox_mac.Text);
            komut.Parameters.AddWithValue("@islemci", textBox_islemci.Text);
            komut.Parameters.AddWithValue("@ram", textBox_ram.Text);


            komut.ExecuteNonQuery();
                
            baglanti.Close();
                
            //Environment.Exit(0);

            //TextBox lardaki bilgilerin veritabanında daha önce kayıt edilmiş mi kontrol edilmesi kaldı




        }


    }
}

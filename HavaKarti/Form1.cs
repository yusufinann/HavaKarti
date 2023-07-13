using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HavaKarti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortDateString();
            string api = "9a2eb287870ff6230de40247b1811644";
            string connection = "http://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument hava = XDocument.Load(connection);
            var sicaklik =XDocument.Load(connection).Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var ruzgar = XDocument.Load(connection).Descendants("speed").ElementAt(0).Attribute("value").Value;
            var nem = XDocument.Load(connection).Descendants("humidity").ElementAt(0).Attribute("value").Value;
            var durum = XDocument.Load(connection).Descendants("weather").ElementAt(0).Attribute("value").Value;
            



            LblSicaklik.Text = sicaklik.ToString();
            LblRuzgar.Text = ruzgar + " m/s ";
            LblNem.Text = nem + " % ";
            LblDurum.Text = durum;
            label6.Text = sicaklik.ToString();

            if (durum == "açık")
            {
                pictureBox1.ImageLocation = @"C:\Users\iinan\Desktop\HavaKarti\istockphoto-1297706369-612x612.jpg";
            }
            if (durum == "bulutlu")
            {
                pictureBox1.ImageLocation = @"C:\Users\iinan\Desktop\HavaKarti\bulutlu.png";
            }
            if (durum == "yağmurlu")
            {
                pictureBox1.ImageLocation = @"C:\Users\iinan\Desktop\HavaKarti\yağmurlu.jpeg";
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
} 

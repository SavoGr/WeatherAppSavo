using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.Threading;
using System.Collections.Generic;
using System.Drawing;


namespace WeatherAppSavo
{
    public partial class Form1 : Form
    { const string MY_ID = "657eafc1cedf6a1a06d85ac64d4e4c89";
        public Form1()
        {
            InitializeComponent();
            pbSlikaPravcaVetra.Image = new Bitmap(pbSlikaPravcaVetra.Width, pbSlikaPravcaVetra.Height);




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CitanjeJSON citanje = new CitanjeJSON();
            //citanje.ucitajGradove();
            try
            {
                try
                {
                    ucitajPodatkeZaLokaciju("Belgrade", "RS", MY_ID);
                    ucitajGradove();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Greska pri ucitavanju", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message, "Greska pri povezivanju na server", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        public void ucitajPodatkeZaLokaciju(string imeGrada,string skracenicaDrzave,string APIid)
        {
            WebClient wc = new WebClient();
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0},{1}&appid={2}", imeGrada, skracenicaDrzave, APIid);
            var json = wc.DownloadString(url);
            var odgovor = JsonConvert.DeserializeObject<Vreme.klasa>(json);
            Vreme.klasa rez = odgovor;
            lGrad.Text = rez.name.ToString();
            lDrzava.Text = rez.sys.country.ToString()+", ";
            lTemperatura.Text = "Temperatura: " + (rez.main.temp - 273.15).ToString();
            lTemperaturaMin.Text = "Minimalna Temperatura: " + (rez.main.temp_min - 273.15).ToString();
            lTemperaturaMax.Text = "Maksimalna Temperatura: " + (rez.main.temp_max - 273.15).ToString();
            lBrzinaVetra.Text = string.Format("Brzina vetra: {0} m/s ({1} km/s) ", rez.wind.speed, (rez.wind.speed * 3.6));
            lPritisak.Text = string.Format("Vazdusni pritisak: {0} mbar", rez.main.pressure);
            lOpis.Text = string.Format("Opis: {0}", rez.weather[0].description);

            //iscrtavanje 
            iscrtajPravacVetra(rez.wind.deg);

            




        }

        //Metod za iscrtavanje pravca duvanja vetra
        public void iscrtajPravacVetra(double stepeni)
        {
            using (var g = Graphics.FromImage(pbSlikaPravcaVetra.Image))
            {
                int duzina =(int) pbSlikaPravcaVetra.Width / 2;
                g.Clear(Color.Azure);
                g.DrawLine(Pens.Red, new Point(duzina, duzina), new Point((int)(duzina + Math.Cos(stepeni)*duzina), (int)(duzina + Math.Sin(stepeni)*duzina)));
                
                pbSlikaPravcaVetra.Refresh();
            }
        }
        //Ucitavanje fajlova iz datoteke
        public void ucitajGradove()
        {
            CitanjeJSON cit = new CitanjeJSON();
            List<RootObject> lista = cit.ucitajGradove();
            System.Diagnostics.Debug.WriteLine(lista.Capacity);

            foreach(RootObject objekat in lista)
            {
                cbGrad.Items.Add(string.Format("{0},{1}", objekat.name, objekat.country));         }
           
        }
        //NA KLIK DUGMETA
        private void btnSearch_Click(object sender, EventArgs e)
        {
            String odabranGrad = cbGrad.Text;
            string[] reci = odabranGrad.Split(',');
            string grad = reci[0];
            string drzava = reci[1];
            try
            {
                ucitajPodatkeZaLokaciju(grad, drzava, MY_ID);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska pri povezivanju na server", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

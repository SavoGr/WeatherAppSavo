using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherAppSavo
{
    class Vreme
    {
        //klasa za koordinate
        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set; }

        }
        //
        
            //klasa za osnovne informacije o vremenu
        public class weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            

        }//


        //klasa za stanje parametara
        public class main
        {
            public double temp { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
        }
        //
        //klasa za brzinu vetra
        public class wind
        {
            public double speed { get; set; }
            public double deg { get; set; }

        }
        //klasa za lokaciju
        public class sys{
            public string country { get; set; }
            public double sunrise { get; set; }
            public double sunset { get; set; }
        }
        //
        //klasa za dohvatanje
        public class klasa
        {   
            public double dt { get; set; }// dan u milisekundama
            public string name { get; set; }
            public sys sys { get; set; }
            public wind wind { get; set; }
            public main main { get; set; }
            public List<weather> weather { get; set; }
            public coord coord { get; set; }
           
        }
    }
}

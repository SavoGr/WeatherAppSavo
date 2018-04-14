using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Newtonsoft.Json;
 

using System.IO;


namespace WeatherAppSavo
{
    class CitanjeJSON
    {
        string link = "C:\\Users\\Savoo\\Visual Studio Projects\\WeatherAppSavo\\WeatherAppSavo\\lg.json";
        public List<RootObject> ucitajGradove()
        {
            StreamReader sr = new StreamReader(link);
            string ucitano = sr.ReadToEnd();
            var res = JsonConvert.DeserializeObject<List<RootObject>>(ucitano);
            List<RootObject> listaGradova = res;
            return res;
        }
    }
}

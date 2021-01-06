using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;


namespace Planets.Models
{
    public class SpaceObjects
    {
        public ObservableCollection<SpaceObject> AllObjects { get; set; }
        public SpaceObjects() 
        {
            AllObjects = new ObservableCollection<SpaceObject>();
            AllObjects.Add(new SpaceObject { CurrentName = "Mercury", Velocity = 300, Size = 2439.7 });
            APIRefresh();
        }
        public async Task APIRefresh()
        {
            HttpClient HC = new HttpClient();
            DateTime DT = DateTime.Now;
            DateTime DTb = DT.AddDays(-1);
            string URL = $"https://api.nasa.gov/neo/rest/v1/feed?start_date={DTb.ToString("yyyy-MM-dd")}&end_date={DT.ToString("yyyy-MM-dd")}&api_key=hkxsVmmgRja7xcnPNXiTirSSszjd59aJEqEXVCg9";
            //string URL = $"https://api.nasa.gov/neo/rest/v1/feed?start_date=2015-09-07&end_date=2015-09-08&api_key=9fE9WVzv1ccw53NHc7Iw29alSpJ65XcljtdvYrrs";
            try
            {
                HttpResponseMessage HRM = await HC.GetAsync(URL, HttpCompletionOption.ResponseContentRead);
                string Vysledek = await HRM.Content.ReadAsStringAsync();
                JObject JO = JObject.Parse(Vysledek);
                for (int i = 0; i < 13; i++)
                {
                    SpaceObject SO = new SpaceObject();
                    SO.CurrentName = Convert.ToString(JO["near_earth_objects"][DTb.ToString("yyyy-MM-dd")][i]["name"]);
                    SO.Velocity = Convert.ToDouble((JO["near_earth_objects"][DTb.ToString("yyyy-MM-dd")][i]["close_approach_data"][0]["relative_velocity"]["kilometers_per_hour"]));
                    SO.Size = Convert.ToDouble((JO["near_earth_objects"][DTb.ToString("yyyy-MM-dd")][i]["estimated_diameter"]["kilometers"]["estimated_diameter_max"]));
                    AllObjects.Add(SO);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

using Newtonsoft.Json;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Service
{
    public class CarRESTService
    {
        readonly string uri = "http://localhost:2599/api/cars";

        public List<Car> GetCars()
        {
            using (WebClient webClient = new WebClient())
            {
                return JsonConvert.DeserializeObject<List<Car>>
                (
                    webClient.DownloadString(uri)
                );
            }
        }

        public async Task<List<Car>> GetCarsAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                return JsonConvert.DeserializeObject<List<Car>>
                (
                    await httpClient.GetStringAsync(uri)
                );
            }
        }
    }
}
using MasGlobalEMSCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MasGlobalEmpInfra
{
    
    public class EmpClient
    {
        HttpClient client = new HttpClient();
        public  async Task<IEnumerable<Emp>> GetEmployeesAsync()
        {
            IEnumerable<Emp> emplist = new List<Emp>();
            client.BaseAddress = new Uri("https://masglobaltestapi.azurewebsites.net/api/Employees");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage response = client.GetAsync(client.BaseAddress).Result;
                if (response.IsSuccessStatusCode)
                {
                    var empJsonString = await response.Content.ReadAsStringAsync();
                    emplist = JsonConvert.DeserializeObject<IEnumerable<Emp>>(empJsonString);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
                Console.WriteLine(ex.Message);
            }
            return emplist;
        }

        
    }
}

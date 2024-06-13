using Api;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APIS_consumir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
            var client = new RestClient("https://apiv2.allsportsapi.com/");
            var request = new RestRequest("football?met=Countries&APIkey=651e021043af5ae3d5d7658a7cf514502022b267825a18dda55779b977341430", Method.Get);
            RestResponse response =  client.Execute(request);
            if (response.IsSuccessStatusCode)
            {
             ListaPaises misPaises=   JsonConvert.DeserializeObject<ListaPaises>(response.Content);
            }
            else
            {
                Console.WriteLine(response.Content);
            }
            Console.ReadLine();
            Console.WriteLine("El acabado");

        }



       
    }

}
    



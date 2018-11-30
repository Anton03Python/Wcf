using ConsoleApp4.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя:");
            string userName = Console.ReadLine();

            while (true == true)
            {
                string input = Console.ReadLine();
                var model = new ChatRequest
                {
                    Message = input,
                    Name = userName,
                };
                string json = JsonConvert.SerializeObject(model);
                Send(json);
            }
        }

        static void Send(string input)
        {
            var client = new RestClient("http://localhost:8001/CHAT/");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", input, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var request1 = JsonConvert.DeserializeObject<ChatResponse>(response.Content);

            Console.WriteLine(request1.Description);

        }

    }
}

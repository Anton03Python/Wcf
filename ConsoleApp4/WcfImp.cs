using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Models;
using Newtonsoft.Json;

namespace ConsoleApp4
{
    public class WebService : IWebService
    {
        public string Echo()
        {
            Console.WriteLine("Толькочто к нам пытался зайти какой то чел!  :(((");
            return "Hello world!";
        }

        //public string GetMainInfo(GetMainInfoRequest model)
        //{
        //    if (model == null)
        //        return null;

        //    if (model.SellerId == null)


        //    if (model.SellerId == "228")
        //        return "Ti gopnik";


        //    var result = new GetMainInfoResponse
        //    {
        //        Code = 0,
        //        Description = "Success",
        //        Result = new GetMainInfoResult
        //        {
        //            OrderResult = new List<OrderResult>
        //            {
        //                new OrderResult
        //                {
        //                    OrderId = Guid.NewGuid().ToString(),
        //                    Status = "Created",
        //                }
        //            },
        //            SellerResult = new SellerResult
        //            {
        //                TradePlanProcess = 228,
        //            }
        //        }
        //    };

        //    string resultJson = JsonConvert.SerializeObject(result);
        //    return resultJson;

        //}

        public string PostMan(SimpleRequest request)
        {
            Console.WriteLine($"{request.Name} напиисал: {request.Message}");
            return "IOKOKOKOKOKK";
        }

        public GetMainInfoResponse GetMainInfo(GetMainInfoRequest model)
        {
            var result = new GetMainInfoResponse
            {
                Code = 0,
                Description = "Success",
                Result = new GetMainInfoResult
                {
                    OrderResult = new List<OrderResult>
                    {
                        new OrderResult
                        {
                            OrderId = Guid.NewGuid().ToString(),
                            Status = "Created",
                        }
                    },
                    SellerResult = new SellerResult
                    {
                        TradePlanProcess = 228,
                    }
                }
            };
            return result;
        }

        public ChatResponse Chat(ChatRequest model)
        {
            if (model.Name == "Сергей")
                return new ChatResponse { Code = 228, Description = "Сергей забанен на сервере." };


            Console.WriteLine($"Пользователь: {model.Name}");
            Console.WriteLine($"Написал: {model.Message}");
            Console.WriteLine("");

            return new ChatResponse { Code = 0, Description = "Сообщение было успешно отправлено."};
        }
    }
}


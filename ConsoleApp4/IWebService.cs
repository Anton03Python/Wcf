using ConsoleApp4.Models;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace ConsoleApp4
{
    [ServiceContract]
    public interface IWebService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Echo/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string Echo();
        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/PostMan/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string PostMan(SimpleRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/GetMainInfo/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        GetMainInfoResponse GetMainInfo(GetMainInfoRequest model);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/CHAT/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ChatResponse Chat(ChatRequest model);
    }
}
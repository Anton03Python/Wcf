using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    public class GetMainInfoResponse
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public GetMainInfoResult Result { get; set; }

    }

    public class GetMainInfoResult
    {
        public SellerResult SellerResult { get; set; }
        public List<OrderResult> OrderResult { get; set; }
    }

    public class OrderResult
    {
        public string OrderId { get; set; }
        public string Status { get; set; }
        
    }

    public class SellerResult
    {
        public int TradePlanProcess { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    public class GetMainInfoRequest
    {
        public string SellerId { get; set; }
        public List<string> Orders { get; set; }
    }
}

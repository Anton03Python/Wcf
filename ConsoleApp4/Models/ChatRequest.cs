using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    [DataContract]
    public class ChatRequest
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]

        public string Mesaage { get; set; }
    }
}

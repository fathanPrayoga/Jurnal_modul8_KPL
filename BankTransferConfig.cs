using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_103022330070
{
    class BankTransferConfig
    {
       
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public List<String> methods { get; set; }
        public Confirmation confirmation { get; set; }


        public class Transfer()
        {
            public int threshold { get; set; }
            public int low_fee { get; set; }
            public int high_fee { get; set; }
        }

        public class Confirmation()
        {
            public string en { get; set; }
            public string id { get; set; }
        }

        public BankTransferConfig LoadConfig(string filePath)
        {
            filePath = "bank_transfer_config.json";
            String Json = File.ReadAllText(filePath);
            var config = JsonSerializer.Deserialize<BankTransferConfig>(Json);
            
            return config;

        } 
    }
}




using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace GtkDesafio3
{
    public class Json
    {


        public Logs DesUS() => JsonConvert.DeserializeObject<Logs>(File.ReadAllText(@"./Json_Data/Data_Program.json"));
        public string SereUS(Logs b) => JsonConvert.SerializeObject(b);

        public class Logs
        {

            public List<Log> Log { get; set; }
        }

        public class Log
        {

            public string User { get; set; }

            public string Pass { get; set; }
        }
    }
}

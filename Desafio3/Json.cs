using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Desafio3
{
    public class Json
    {
        public string SelfDir = Directory.GetCurrentDirectory();

        public Logs DesUS() => JsonConvert.DeserializeObject<Logs>(File.ReadAllText(SelfDir+"/../Json_Data/Data_Program.json"));
            public string SereUS(Logs b) => JsonConvert.SerializeObject(b);


            public DATA_TEMP DesTemp() => JsonConvert.DeserializeObject<DATA_TEMP>(File.ReadAllText(SelfDir + "/../Json_Data/Data_Temp.json"));
            public string SereTemp(DATA_TEMP b) => JsonConvert.SerializeObject(b);

        public void Save(string data)=> File.WriteAllText(@"Logs.json", data);

        public class Logs
            {

                public List<Log> Log { get; set; }
            }

            public class Log
            {

                public string User { get; set; }

                public string Pass { get; set; }
            }


           

            public class DATA_LIST
            {
                public string NOM_EMPLE { get; set; }
                public string CODE_EMPLE { get; set; }
                public int HORA_EMPLE { get; set; }
                public double AFP { get; set; }
                public double RENTA { get; set; }
                public double ISS { get; set; }
                public double SAL_LIQUIDO { get; set; }
                public double SAL_NETO { get; set; }
            }
        public class DATA_TEMP
        {
            public List<DATA_LIST> DATA { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace Desafio3
{
    public class Calc
    {
        Json js = new Json();

        double AFPC, ContDes, SalLog, SalNet, ISSC, RENTC;
        double HT;
        bool Error;

        public List<DATA_LIST1> Empresa(string NOM, string CODE, int HORA)
        {

            string ruta = js.SelfDir + "/../Json_Data/Data_Temp.json";


            List<DATA_LIST1> dATA_s = new List<DATA_LIST1>();

            const double afp = 0.0688, isss = 0.0525, renta = 0.1;
            if (HORA <= 160)
            {
                HT = HORA * 9.75;
            }
            else if (HORA > 160 && HORA <= 200)
            {
                HT = (160 * 9.75) + ((HORA - 160) * 11.50);
            }
            else if (HORA > 200 && HORA <= 250)
            {
                HT = (160 * 9.75) + (40 * 11.50) + ((HORA - 200) * 12.50);
            }
            if (HT > 0)
            {
                SalLog = HT;
                ContDes = 0;
                AFPC = HT * afp; ISSC = HT * isss; RENTC = HT * renta;
                ContDes = AFPC + ISSC + RENTC;
                SalNet = SalLog - ContDes;

                var datos = File.ReadAllText(ruta);
                var DATA_DESE_JS = JsonConvert.DeserializeObject<DATA_TEMP>(datos);
                DATA_DESE_JS.DATA.Add(new DATA_LIST
                {
                    NOM_EMPLE = NOM,
                    CODE_EMPLE = CODE,
                    HORA_EMPLE = HORA,
                    AFP = AFPC,
                    RENTA = RENTC,
                    ISS = ISSC,
                    SAL_LIQUIDO = SalLog,
                    SAL_NETO = SalNet

                });
                File.WriteAllText(ruta, JsonConvert.SerializeObject(DATA_DESE_JS));
            }
            else
            {
                Error = true;
            }

            dATA_s.Add(new DATA_LIST1 { NOM_EMPLE1 = NOM, CODE_EMPLE1 = CODE, HORA_EMPLE1 = HORA, RENTA1 = RENTC, AFP1 = AFPC, ISS1 = ISSC, SAL_LIQUIDO1 = SalLog, SAL_NETO1 = SalNet, e = Error });



            return dATA_s;

        }

        public class DATA_LIST1
        {
            public string NOM_EMPLE1 { get; set; }
            public string CODE_EMPLE1 { get; set; }
            public int HORA_EMPLE1 { get; set; }
            public double AFP1 { get; set; }
            public double RENTA1 { get; set; }
            public double ISS1 { get; set; }
            public double SAL_LIQUIDO1 { get; set; }
            public double SAL_NETO1 { get; set; }
            public bool e { get; set; }
        }
        public class DATA_TEMP
        {
            public List<DATA_LIST> DATA { get; set; }
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
    }
}
using System;
namespace GtkDesafio3
{
    public class Calc
    {
        double HT;
        bool Error;
        public bool Empresa(string NOM, string CODE, int HORA)
        {
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
                double SalLoq = HT;
                double ContDes = 0;
                double AFP = (HT * afp), ISS = (HT * isss), RENT = (HT * renta);
                ContDes = AFP + ISS + RENT;
                double SalNet = SalLoq - ContDes;

            }
            else
            {
                Error = true;
            }

            return Error;

        }
    }

}

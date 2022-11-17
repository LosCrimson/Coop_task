using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coop_task
{
    public class Var_Sum
    {
        float zemesPlotas;
        float zemesTuris;
        float izambine;
        float suma;
        float vidurkis;

        public void getIzambine()
        {
            //========================
            // Įžambinės skaičiavimas
            //=======================

            int a = 10;
            int b = 15;
            this.izambine = (float)Math.Sqrt((float)Math.Pow(a, 2) + (float)Math.Pow(b, 2));
        }

        public void writeIzambine()
        {
            Console.WriteLine("Trikampio ižambinės ilgis: {0}", this.izambine);
        }
    }
}

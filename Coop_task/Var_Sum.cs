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
        public void CountEarthArea () 
        {
            float radius = 6371;
            this.zemesPlotas = 4 * (float)Math.PI * (float)Math.Pow(radius, 2.0);
        }
        public void Task2()
        {
            float r = 6371; // radius
            this.zemesTuris=(4/3)*(float)Math.PI*(float)Math.Pow(r,3.0);
            Console.WriteLine(this.zemesTuris);
            Console.ReadLine();
        }
    }
}

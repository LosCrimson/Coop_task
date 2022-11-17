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

        public void Task2()
        {   
            float r = 6371; // radius

            this.zemesTuris=(4/3)*(float)Math.PI*(float)Math.Pow(r,3.0);

            Console.WriteLine(this.zemesTuris);
            Console.ReadLine();
        }

    }
}

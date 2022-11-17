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

        public void CountEarthArea () 
        {
            float radius = 6371;

            this.zemesPlotas = 4*(float)Math.PI*(float)Math.Pow(radius, 2.0);
        }

    }
}

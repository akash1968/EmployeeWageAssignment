using System;
using System.Collections.Generic;

namespace UC1
{
    public class Program
    {

        static void Main(string[] args)
        {
            Main capg = new Main();
            Main wip = new Main();
            capg.CalculateEmpWages("Reliance", 20, 3, 20);

            wip.CalculateEmpWages("DMart", 20, 4, 30);

        }



    }
}
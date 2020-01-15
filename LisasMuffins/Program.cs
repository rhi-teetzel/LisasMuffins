using System;

namespace LisasMuffins
{
    class Program
    {
        static void Main(string[] args)
        {

            //Initialize Variables
            int cupsOfSugarRecipe = 7;
            int currentCupsOfSugar = 2;
            int remainingCupsRequired = 0;

            //Variable Computation
            remainingCupsRequired = cupsOfSugarRecipe - currentCupsOfSugar;

            //Variable Output
            Console.WriteLine("This program is to help Lisa do simple math.");
            Console.WriteLine("Lisa still needs {0} cups", remainingCupsRequired);

            Console.ReadKey();

        }
            
    }
}

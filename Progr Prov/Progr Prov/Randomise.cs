using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progr_Prov
{
    class Randomise
    {
        private Random randGen = new Random(); // Slump generatorn

        public int RandInt(int num1, int num2)
        {
            int retVal; // retVal = return value

            retVal = randGen.Next(num1, num2 + 1);

            return retVal;
        }//Slumpar mellan två ints

        public string RandString(string[] total)
        {
            int retVal; //retVal = return value

           retVal = randGen.Next(0, total.Length);

            return total[retVal];
        } //Slumpar en string från en string array
    }
}

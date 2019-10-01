using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progr_Prov
{
    class WriteOut
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
            Console.ReadLine();
        } //Skriver ut en string

        public void WriteSpecial(string text, bool ignoreReadLine)
        {
            Console.Write(text);

            if (ignoreReadLine == false)
            {
                Console.ReadLine();
            }
        } //Skriver ut med "Console.Write();" och denna metod ger chansen att ignorera "ReadLine"
    }
}

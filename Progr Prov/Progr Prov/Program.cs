using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progr_Prov
{
    class Program
    {


        static void Main(string[] args)
        {
            List<Bok> bookStock = new List<Bok>(); //Lista på alla böcker i bokaffären
            Randomise rand = new Randomise(); //Slump generatorn
            WriteOut write = new WriteOut(); // Skriver ut string

            Add4First(bookStock); //Lägger 4 nya böcker i bokaffären

            write.Write("Welcom to book seller simulator 101.\nYou will be start your journey with these 4 book and this book store!\n Good Luck!");

            Console.Clear();

            write.Write("Start to set the prises of the four book!");

            for (int i = 0; i < 4; i++) //
            {
                SetPrise(bookStock, i);
            } //Låter spelaren sätta priset för 4a böcker

        }

        static void Add4First(List<Bok> bookStock)
        {

            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    Bok bok1 = new Bok();
                    bookStock.Add(bok1);
                }

                if (i == 1)
                {
                    Bok bok2 = new Bok();
                    bookStock.Add(bok2);
                }

                if (i == 2)
                {
                    Bok bok3 = new Bok();
                    bookStock.Add(bok3);
                }

                if (i == 3)
                {
                    Bok bok4 = new Bok();
                    bookStock.Add(bok4);
                }
            }
        }  //Lägger 4 nya böcker i bokaffären

        static void SetPrise(List<Bok> bookStock, int book)
        {
            bookStock[book].SetPrise();
        } //Låter spelaren sätta priset för 4a böcker
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progr_Prov
{

    class Bok
    {
        private Randomise rand = new Randomise(); //En klass som specialiserar sig med att slumpa.
        private WriteOut write = new WriteOut();  //En klass som specialerserar sig med att skriva ut text.

        private string[] categoryALL = { "Action", "Scary", "Novel", "Dubbel Action" }; //En array som är fylld med olika typer av kategorier.
        private string[] nameAll = { "Eberts dangerous encounter", "IT's cold 2", "Animal gravey-yard", "Bip Bop Future" }; //En Array som är fylld med olika namn.


        public int price; //Priset som spelaren sätter
        private string name; //Namnet på boken
        private int rarity; //Sällsyntheten på boken
        private string category; //Kategorin på boken
        private int acualValue; // Det riktiga värdet
        private bool cursed; //Om boken har en förbannelse

        public Bok() //Slumpar allt förutom priset som spelaren sätter
        {
            name = rand.RandString(nameAll);
            rarity = rand.RandInt(0, 5);
            category = rand.RandString(categoryALL);
            cursed = Cursed();
            acualValue = Evaluate();
        }

        private bool Cursed()
        {
            int isCursed = rand.RandInt(1, 2);
            if (isCursed == 2)
            {
                cursed = false;

            }
            else if (isCursed == 1)
            {
                cursed = true;
            }

            return cursed;
        } //Metoden slumpar om boken har en förbannelse
        private int Evaluate()
        {
            acualValue = rand.RandInt(5, 50) * rarity;
            return acualValue;
        } //Metoden slumpar vad boken riktiga värde är

        public void PrintInfo()
        {
            string isCursed;

            if (cursed == true)
            {
                isCursed = "Yes";
            }
            else
            {
                isCursed = "No";
            }

            write.Write("Name of book: " + name + "\nRarity: " + rarity + "\nCategory: " + category + "\nAcual Value: " + acualValue + "\nCurse: " + isCursed);
        } //Skriver ut alla alla variabler
        public string GetName()
        {
            return name;
        } //Retunerar en namnet på boken
        public int GetRarity()
        {
            return rarity;
        } //Retunerar en Sällsyntheten på boken
        public void SetPrise()
        {
            write.WriteSpecial("Name: " + name + "\nRarity: " + rarity + "\nAcual Prise: " + acualValue + "\n\nPrise", true);
            string text = Console.ReadLine();

            price = int.Parse(text); //Hadde inte tid att fixa en fail safe

        } //Sätter priset på boken *Har ingen fail safe*
    }
}

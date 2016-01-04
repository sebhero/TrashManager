using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashManager
{
    class Menu
    {

        //TODO byta ut string med object av ber'knings saken.
        private Dictionary<int, MenuItem> menuAlternatives;

        public Menu()
        {
            this.menuAlternatives = new Dictionary<int, MenuItem>();
         //creates the diffrent objects  
            //l'gger till dem i en map. som man l'nkar int med object.
            this.menuAlternatives.Add(1,new WholeNumbersFor());
            this.menuAlternatives.Add(2,new FloatingNumberWhile());
            this.menuAlternatives.Add(3, new ExchangeDoWhile());
            this.menuAlternatives.Add(4, new WasteColletion());
        }

        public void start()
        {
            int choice=0;
            MenuItem currentChoice;
            do
            {
                
                writeMenuText();
                printTxt("Your choice: ");
                //TODO exception escape point.
                choice = Convert.ToInt32(Console.ReadLine());
                this.menuAlternatives.TryGetValue(choice,out currentChoice);
                if(currentChoice != null)
                {
                    currentChoice.start();
                }
            } while (choice != 0);
        }
        private void writeMenuText()
        {
            printChar('-',30);
            printLnTxt("\tProgram Menu");
            printChar('-',30);
            printLnTxt("Whole Numbers with For \t\t\t : 1");
            printLnTxt("Floating Point Number with While\t : 2");
            printLnTxt("Currency Converter with DO While-loop\t : 3");
            printLnTxt("WasteSchedule \t\t\t\t : 4");
            printLnTxt("Exit \t\t\t\t\t : 0");
            printChar('-',30);
        }

        private void printLnTxt(string text)
        {
            Console.WriteLine(text);
        }

        private void printTxt(string text)
        {
            Console.Write(text);
        }

        private void printChar(char s,int count)
        {
               for (int i = 0; i < count; i++)
               {
                   Console.Write(s);
               }
           Console.WriteLine();
        }
    }
}

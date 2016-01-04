using System;

namespace TrashManager
{
    internal class WasteColletion : MenuItem
    {
        private int _pickupWeek;

        public override void start()
        {
            //forsta ggn.
            writeProgramInfo();
            readInput();
            //tills anvandaren valjer att avsluta.
            while (_pickupWeek != 0)
            {
                showResults();
                readInput();
            }
            
        }

        protected override void showResults()
        {
            //Loopar igenom alla veckor baserat po typ av pickup
            for (int i = _pickupWeek; i <= 52; i += _pickupWeek)
            {
                Console.Write("{0,13} {1,2}","Week", i);
            }
        }

        protected override void readInput()
        {
            printLnTxt();
            printLnTxt("for ever other week \t => 1" );
            printLnTxt("for ever 6th week \t => 2" );
            printLnTxt("exit \t\t\t => 0");
            printTxt("Your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            //definerar efter input vilka veckor som galler.
            switch (choice)
            {
                case 1:
                    _pickupWeek = 2;
                    break;
                case 2:
                    _pickupWeek = 4;
                    break;
                case 0:
                    //alt kunde jag anvant return varde;
                    _pickupWeek = 0;
                    break;
            }
        }

        protected override void writeProgramInfo()
        {
            this.printChar('*', 10);
            this.printTxt("Empty bins");
            this.printChar('*', 10);
            printLnTxt("\n\t Using a for and while statement");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashManager
{
    class FloatingNumberWhile:MenuItem
    {

        private double _sum;

        public override void start()
        {
               Console.WriteLine("FLoatingnumber called");
            writeProgramInfo();
            readInput();
            showResults();
        }

        protected override void showResults()
        {
            printTxt("result :");
            printTxt(_sum.ToString());
            printLnTxt();
        }

        protected override void readInput()
        {
            double num = 0.0;

            bool done = false;

            while (!done)
            {
                printTxt("input number (0 to exit): " );
                num=readInputDbl();

                if (num == 0.0)
                {
                    done = true;
                }
                this._sum += num;
            }
        }


        private double readInputDbl()
        {
            return  Convert.ToDouble(Console.ReadLine());
        }

        protected override void writeProgramInfo()
        {
            this.printChar('*', 10);
            this.printTxt("Sum of floating numbers");
            this.printChar('*', 10);
            printLnTxt("\n\t Using a while statement");
        }
    }
}

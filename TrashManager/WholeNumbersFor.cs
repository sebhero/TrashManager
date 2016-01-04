using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashManager
{
    class WholeNumbersFor:MenuItem
    {

        private int _numOfInputs, _sum;

        public override void start()
        {
            writeProgramInfo();
            readInput();
            sumNumbers();
            showResults();
        }

        private void sumNumbers()
        {

            int index;

            for (index = 0; index < _numOfInputs; index++)
            {
                this._sum += Convert.ToInt32(Console.ReadLine());
             }

        }

        protected override void showResults()
        {
            printLnTxt(string.Format("the sum is \t {0}",this._sum.ToString()));
        }

        protected override void readInput()
        {
            printTxt("numbers of values to sum: ");
            this._numOfInputs = Convert.ToInt32(Console.ReadLine());
        }

        protected override void writeProgramInfo()
        {
            this.printChar('*', 10);
            this.printTxt("Sum of whole numbers");
            this.printChar('*',10);
            printLnTxt("\n\t Using a for statement");
        }
    }
}

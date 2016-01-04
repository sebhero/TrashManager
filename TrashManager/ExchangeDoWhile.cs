using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashManager
{
    class ExchangeDoWhile:MenuItem
    {
        private double _exchangeRate;
        private double _sum;

        public override void start()
        {
            writeProgramInfo();
            readInput();
            showResults();
        }

        protected override void showResults()
        {
            _sum = _sum*_exchangeRate;
            printLnTxt("result :"+_sum);
        }

        protected override void readInput()
        {
            double input = 0.0;
            printTxt("Exchange rate: ");
            _exchangeRate= Convert.ToDouble(Console.ReadLine());

            do
            {
                printTxt("add input that will add up to sum you would like to exchange (0 to exit): ");
                input =Convert.ToDouble(Console.ReadLine());
                _sum += input;

            } while (input != 0);

        }

        protected override void writeProgramInfo()
        {
            this.printChar('*', 10);
            this.printTxt("convert currance");
            this.printChar('*', 10);
            printLnTxt("\n\t Using a do while statement");
        }
    }
}

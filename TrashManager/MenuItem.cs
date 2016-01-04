using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashManager
{
    abstract class MenuItem
    {
        public abstract void start();

        protected void printLnTxt(string text)
        {
            Console.WriteLine(text);
        }
        protected void printLnTxt()
        {
            Console.WriteLine();
        }

        protected abstract void showResults();

        protected abstract void readInput();

        protected abstract void writeProgramInfo();

        protected void printTxt(string text)
        {
            Console.Write(text);
        }

        protected void printChar(char s, int count)
        {
            for (var i = 0; i < count; i++)
            {
                Console.Write(s);
            }
        }

    }
}

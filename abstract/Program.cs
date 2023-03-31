using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    internal abstract class Calculatorabs
    {
        int a = 10;
        int b = 20;
        public abstract int c { get; set; }
        public int sum(int a, int b) 
        {
            return a + b;
        }
    }
    class test
    { 
        static void Main(string[] args)
        {
        }
    }
}

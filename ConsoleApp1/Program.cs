using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<int>() { 1, 2, 3, 4 };

            var le = from o in a where o % 2 != 0 select o;
            //var le2 = a.Where(h => h %2! = 0);
             var hsss = new List<hocsinh>
             {

             }
            
        }

    }
    class hocsinh
    {
        int id;
        public int Id
        {
            get => id;
        }
    }
}

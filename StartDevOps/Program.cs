using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartDevOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new OddNo().IsOddNo(3).ToString());
            Console.ReadLine();
        }
    }
    public class OddNo
    {
        public bool IsOddNo(int no)
        {
            return no % 2 == 0 ? false : true;
        }
    }
}

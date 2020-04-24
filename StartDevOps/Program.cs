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
            try
            {
                Console.WriteLine(new OddNo().IsOddNo(3).ToString());
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                throw;
            }
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

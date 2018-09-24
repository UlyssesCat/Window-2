using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static long factorial(long num)
        {
            long faresult = 1;
            if(num>1)
            {
                for(int i=1;i<=num;i++)
                {
                    faresult = faresult * i;
                }
            }
            return faresult;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDLLTest
{
    class Program
    {
        [DllImport(@"../../../Debug/Project2.dll", EntryPoint = "test01", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]

        extern static int test01(int a, int b, int c);

        [DllImport(@"../../../Debug/Project2.dll", EntryPoint = "test02", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]

        extern static int test02(int a, int b);
        static void Main(string[] args)
        {
            int r1 = test01(1, 2, 3);

            int r2 = test02(5, 2);

            Console.WriteLine("test01结果：" + r1.ToString());

            Console.WriteLine("test02结果：" + r2.ToString());

            Console.ReadKey();
        }
    }
}

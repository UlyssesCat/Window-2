using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.IO;
using System.Reflection;

namespace DLLtest
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamWriter sw = new StreamWriter("out.txt");
            //sw.WriteLine(Class1.factorial(10));
            //sw.Close();

            //StreamWriter sw = new StreamWriter("out.txt");
            //Assembly a = Assembly.LoadFrom("ClassLibrary1.dll");
            //foreach (Type t in a.GetTypes())
            //{
            //    if (t.IsClass && !t.IsAbstract)
            //    {
            //        MethodInfo mi = t.GetMethod("factorial");
            //        object o = Activator.CreateInstance(t);
            //        Object[] parameters = new Object[1];
            //        parameters[0] = 10;
            //        sw.WriteLine(mi.Invoke(o, parameters));
            //    }
            //}
            //sw.Close();

            StreamWriter sw = new StreamWriter("out.txt");
            Assembly a = Assembly.LoadFrom("ClassLibrary1.dll");
            foreach (Type t in a.GetTypes())
            {
                if (t.IsClass && !t.IsAbstract)
                {
                    MethodInfo[] miArr = t.GetMethods();
                    object o = Activator.CreateInstance(t);
                    foreach (MethodInfo mi in miArr)
                    {
                        sw.WriteLine(mi.Name);
                    }
                }
            }
            sw.Close();


        }
    }
}

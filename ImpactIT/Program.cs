using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ImpactIT
{
    class Program
    {
        //public delegate void SomeMetgodDel(); //tutaj tworzymy delegat

        static void Main(string[] args)
        {


            //SomeMetgodDel someDele = SomeMethod; //tutaj robimy wskaźnik
            //someDele.Invoke();
            
            SomeLongRunningData sm = new SomeLongRunningData();
            sm.SomeMethod(CallBackMethod);
            
            //Dynamic

         //   string tojeststring = "aa";
         //
         //   var mvar = 1 + 3;
         //   dynamic dyn = 1 + 3;
         //   object obj = 1 + 3;
         //   Console.WriteLine(mvar.GetType());
         //   Console.WriteLine(dyn.GetType());
         //   Console.WriteLine(obj.GetType());
         /*
            dynamic dyna;
            int a = 20;

            dyna = a;

            string b = "dynamic";

            dyna = b;

            DateTime dt = DateTime.Now;

            dyna = dt;
            */

            Console.ReadKey();
        }
        /*
        public static void SomeMethod()
        {
            Console.WriteLine("Jestem tu !!");
        }
        */
        static void CallBackMethod(int i)
        {
            Console.WriteLine(i);
        }
        

        public class SomeLongRunningData
        {
            public delegate void CallBack(int i);

            public void SomeMethod(CallBack obj)
            {
                for (int i = 0; i < 1000; i++)
                {
                    //Robi się coś w tle
                    obj(i);
                }
            }
        }
    }
}

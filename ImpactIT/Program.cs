using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImpactIT.Delegaty;


namespace ImpactIT
{
    class Program
    {
        public delegate void SomeMetgodDel(); //tutaj tworzymy delegat
        static void Main(string[] args)
        {
            

             SomeMetgodDel someDele = SomeMethod; //tutaj robimy wskaźnik
             someDele.Invoke();

             Console.ReadKey();

            SomeLongRunningData sm = new SomeLongRunningData();
            sm.SomeMethod(CallBackMethod);

            Console.ReadKey();
        }


        public static void SomeMethod()
        {
            Console.WriteLine("Jestem tu !!");
        }

        static void CallBackMethod(int i)
        {
          Console.WriteLine(i);
        }
    }
    class SomeLongRunningData
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

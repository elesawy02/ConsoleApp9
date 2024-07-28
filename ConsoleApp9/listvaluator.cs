using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public delegate bool filterdelgate(int n);





    internal class listvaluator
    {


        public static List<int> GETNUMBERS(List<int> list,filterdelgate dlg)
        {
            List<int> result = new List<int>();
            foreach (var item in list)
            {
                if (dlg.Invoke(item)) 
                {
                    result.Add(item);
                }

            }
            return result;


        }



        public static List<int> GETODDNUMBERS(List<int> list)
        {
            List<int> result = new List<int>();
            foreach (var item in list)
            {
                if (item % 2 != 0)
                {
                    result.Add(item);
                }
                
            }
            return result;


        }

        public static List<int> GETEVENNUMBERS(List<int> list)
        {
            List<int> result = new List<int>();
            foreach (var item in list)
            {
                if (item % 2 == 0)
                {
                    result.Add(item);
                }
                
            }
            return result;


        }



        public static bool odd(int x)
        {
            return (x % 2 == 0);
        }

        public static bool even(int x)
        {
            return (x % 2 != 0);
        }


        public static bool divby5 (int x)
        {
            return (x % 5 == 0);
        }
    }
}

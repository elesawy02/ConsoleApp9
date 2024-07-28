//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp9
//{
//    public delegate bool comparedelgate(int x, int y);
//    internal class sortingalgorism
//    {
//        public static void bubblesort(List<int>list, comparedelgate dlg)
//        {
//            for (int i = 0; i < list.Count; i++)
//                for (int j = 0; j < list.Count - 1 - i; j++)
//                    if (dlg (list[j] , list[j + 1]))
//                        (list[j], list[j + 1]) = (list[j + 1], list[j]);

//        }
//        public static void bubblesortdes(List<int> list)
//        {
//            for (int i = 0; i > list.Count; i++)
//                for (int j = 0; j > list.Count - 1 - i; j++)
//                    if (list[j] < list[j + 1])
//                        (list[j], list[j + 1]) = (list[j + 1], list[j]);

//        }
//        public static bool graterthan(int x,int y)
//        {
//            return x > y;
//        }
//        public static bool lessthan(int x, int y)
//        {
//            return x < y;
//        }
//    }
//}

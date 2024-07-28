//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp9
//{
//    public delegate int calculatordelgate(int x, int y);
//    internal class calculator
//    {
//        public static void calculate(int n1, int n2, char op)
//        {
//            int result;

//            if (op == '+')
//            {
//                result = n1 + n2;
//                Console.WriteLine(result);
//            }
//            else if (op == '-')
//            {
//                result = n1 - n2;
//                Console.WriteLine(result);
//            }

//            else if (op == '*')
//            {
//                result = n1 * n2;
//                Console.WriteLine(result);
//            }
//            else if (op == '/')
//            {
//                result = n1 / n2;
//                Console.WriteLine(result);

//            }
//            else Console.WriteLine("invalid opreater:");
//        }
//        public static void calculate(int n1, int n2, calculatordelgate dlg)
//        {
//            int result = dlg(n1, n2);
//            Console.WriteLine(result);
//        }
//        public static int sum(int x, int y)
//        {
//            return x + y;
//        }
//        public static int sup(int x, int y)
//        {
//            return x - y;
//        }
//        public static int div(int x, int y)
//        {
//            return x / y;
//        }
//        public static int mul(int x, int y)
//        {
//            return x * y;
//        }
//        public static int rem(int x, int y)
//        {
//            return x % y;
//        }

//    }
//}

using System.Collections;

namespace ConsoleApp9
{
    internal class Program
    {
        // public static int sumarray(ArrayList array)
        //    {
        //        int sum = 0;
        //        for (int i = 0; i < array.Count; i++)
        //        {
        //            sum += (int)array[i];
        //        } 
        //        return sum;
        //    }
        //public class customcomparer : IComparer<int>
        //{
        //    public int Compare(int x, int y)
        //    {
        //        return x.CompareTo(y); 
        //    }
        //}

        static void Main(string[] args)
        {
            #region collections
            #region arraylist
            //ArrayList list = new ArrayList();
            //Console.WriteLine($"count={list.Count}:: capacity{list.Capacity}");
            //list.Add(5);
            ////LIST.ADD("500");
            //list.AddRange(new int[]{1, 2, 3, 4, 5});
            //Console.WriteLine($"count={list.Count}:: capacity{list.Capacity}");
            //Console.WriteLine(list[0]);
            //Console.WriteLine(sumarray(list));
            //list.TrimToSize();
            //Console.WriteLine($"count={list.Count}:: capacity{list.Capacity}");

            #endregion
            #region list<t>
            //List<int> list = new List<int>(5);
            //    Console.WriteLine($"count={list.Count}:: capacity{list.Capacity}");
            //list.Add( 1 );
            //list.AddRange( new int[] {1,2,3,4,5} );
            //Console.WriteLine($"count={list.Count}:: capacity{list.Capacity}");
            //list.TrimExcess();
            //Console.WriteLine($"count={list.Count}:: capacity{list.Capacity}");
            //list.Clear();
            //Console.WriteLine($"count={list.Count}:: capacity{list.Capacity}");
            //list.EnsureCapacity(5);
            //Console.WriteLine($"count={list.Count}:: capacity{list.Capacity}");
            //Console.WriteLine(list.EnsureCapacity(5));
            //Console.WriteLine(list.BinarySearch(3));
            //list.Sort(new customcomparer());
            //list.Insert(0, 10 );
            //list.InsertRange(0, new int[] { 10, 20, 30, 40 });
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //list.Remove(30);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion
            #region linkedlist
            //Stack<int> numbers = new Stack<int>();
            //numbers.Push(1);
            //numbers.Push(2);    
            //numbers.Push(3);
            //numbers.Push(4);
            //Console.WriteLine(numbers.Pop());

            //Console.WriteLine(numbers.Pop());

            //Console.WriteLine(numbers.Pop());

            //Console.WriteLine(numbers.Pop());


            //Hashtable Hashtable = new Hashtable();
            //Dictionary<string, long> phonebook = new();
            //phonebook["esawy"] = 123;
            //Console.WriteLine(phonebook["esawy"]);
            //phonebook.Add("mahmoud",456);
            //phonebook.Add("mohamed",789);
            //phonebook.Add("eman", 1020);
            //foreach (var phone in phonebook)
            //{
            //    Console.WriteLine(phone);
            //}
            //if(phonebook.ContainsKey("eman"))
            //    {
            //    Console.WriteLine(phonebook["eman"]);

            //}





            #endregion
            #region delgate
            //int x = 10, y = 5;
            //calculator.calculate(x, y, calculator.sum);
            //calculator.calculate(x, y, calculator.mul);

            //calculator.calculate(x, y, calculator.sup);

            //calculator.calculate(x, y, calculator.div);
            //calculator.calculate(x, y, calculator.rem);

            #endregion

            #region
            //List<int> numbers = new() { 3,5,6,4,2,1,8,7,9};
            //sortingalgorism.bubblesort(numbers, sortingalgorism.graterthan);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine($"item:: {item}");
            //}
            //Console.WriteLine("-----------------------");
            //sortingalgorism.bubblesort(numbers, sortingalgorism.lessthan);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine($"item:: {item}");
            //}
            #endregion


            #region
            //List<int> numbers = Enumerable.Range(10,100).ToList();
            //List <int> oddnumbers = listvaluator.GETODDNUMBERS(numbers);
            //Console.WriteLine("oddnumbers");
            //foreach (var item in oddnumbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("///////////////////////////////");
            //Console.WriteLine("even numbers");

            //List <int> evennumbers = listvaluator.GETEVENNUMBERS(numbers);
            //foreach (var item in evennumbers)
            //{
            //    Console.WriteLine(item);
            //}





            #endregion

            #region


            //            List<int> numbers = Enumerable.Range(10, 100).ToList();
            //            List<int> oddnumbers = listvaluator.GETNUMBERS(numbers, listvaluator.odd);
            //            Console.WriteLine("oddnumbers");
            //            foreach (var item in oddnumbers)
            //            {
            //                Console.WriteLine(item);
            //            }

            //            Console.WriteLine("///////////////////////////////");
            //            Console.WriteLine("even numbers");

            //            List<int> evennumbers = listvaluator.GETNUMBERS(numbers,listvaluator.even);
            //            foreach (var item in evennumbers)
            //            {
            //                Console.WriteLine(item);
            //            }

            //            Console.WriteLine("55555555555555555555555555555555555555");


            //            List<int> divby5=
            //listvaluator.GETNUMBERS(numbers, listvaluator.divby5);
            //            foreach (var item in divby5)
            //            {
            //                Console.WriteLine(item);
            //            }

            #endregion







            #endregion



        }
    }
}

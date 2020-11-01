using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
       

        public static void Main(string[] args)
        {
            //You have two arrays/lists as follows
            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };


            //a. Show the common elements in both lists
            //3 , 4 , 5

          

            Console.WriteLine("**********************");
            Console.WriteLine(" ");

            var list4 = new IEnumerable<int>[] { list1, list2 };

            var commons = GetCommonItems(list4);       
          
            Console.WriteLine(string.Join(" ",commons));




            //b. Show the elements from list1, but is not found in list2
            // 1, 2

            Console.WriteLine(" ");
            Console.WriteLine("**********************");
            Console.WriteLine(" ");

            var list5 = list1.Except(list2);

            Console.WriteLine(string.Join(" ", list5));



            //c. Show the elements from list2,but is not found in list1
            //6 , 7



            Console.WriteLine(" ");
            Console.WriteLine("**********************");
            Console.WriteLine(" ");


            var list6 = list2.Except(list1);  

            Console.WriteLine(string.Join(" ", list6));


            Console.WriteLine(" ");
            Console.WriteLine("**********************");
            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
        }

        //get common items inumerable
        static IEnumerable<T> GetCommonItems<T>(IEnumerable<T>[] lists)
        {
            HashSet<T> hs = new HashSet<T>(lists.First());
            for (int i = 1; i < lists.Length; i++)
                hs.IntersectWith(lists[i]);
            return hs;
        }
    }
}
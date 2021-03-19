using System;
using System.Collections.Generic;

namespace collectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void DoSetDemo()
        {
            Console.WriteLine("\nIn DoSetDemo");
            var set = new HashSet<string>();
            set.Add("Amit");
            set.Add("Sumit");
            set.Add("Aman");
            set.Add("Naman");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

        }
        public static void DoQueueDemo()
        {
            Queue<string> queue = new Queue<string>();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            queue.Enqueue("Amit Rana");
            queue.Enqueue("Sumit Semwal");
            queue.Enqueue("Aman Rawat");
            Console.WriteLine("head::"+queue.Peek());
            Console.WriteLine("\n Iterating the queue elements::");
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue element::"+dequeue);
            Console.WriteLine("/n Iterating the queue elements after dequeue one element::");
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public static void DoDictionaryDemo()
        {
            Console.WriteLine("/n In DoDictionaryDemo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100,"amit");
            dictionary.Add(101, "sumit");
            dictionary.Add(102, "aman");
            Console.WriteLine("Acces value using key::"+dictionary[100]);
            Console.WriteLine("\n Iterating Dictionary");
            foreach (var element in dictionary)
            {
                Console.WriteLine("key="+element.Key+"&value=="+element.Value);

            }
        }
        private static void DoStackDemo()
        {
            Console.WriteLine("\n DoStackDemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Amit");
            stack.Push("aman");
            stack.Push("sumit");
            stack.Push("naman");
            string pop = stack.Pop();
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("poped element::" + pop);
        }
        private static void doListDemo()
        {
            Console.WriteLine("\n DolistDemo");
            List<string> list = new List<string>();
            list.Add("sumit");
            list.Add("amitaman");
            list.Add("raam");
            list.Add("namn");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}

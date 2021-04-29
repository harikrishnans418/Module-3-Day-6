class Class7
    {
        public static void Main()
        {
            LinkedList<string> vs = new LinkedList<string>();
            vs.AddLast("Sudeep");
            vs.AddLast("S");
            vs.AddLast("is");
            vs.AddLast("in");
            vs.AddLast("India");
            Console.WriteLine(vs.First.Value);
            Console.WriteLine(vs.Last.Value);
            Console.WriteLine(vs.Contains("India"));
            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
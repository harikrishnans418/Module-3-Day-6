public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> rep = new Dictionary<char, int>();
            Console.Write("Enter a String : ");
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                int count = 0;
                foreach (char c in word)
                {
                    if (c == word[i])
                    {
                        count++;
                    }
                }
                if (!rep.ContainsKey(word[i]))
                {
                    rep.Add(word[i], count);
                }
            }
            foreach (var item in rep)
            {
                Console.WriteLine("Key = " + item.Key + "; Value = " + item.Value);
            }

            Console.ReadLine();
        }

    }
using System;


namespace ptth
{






    class Program
    {










        static void Main(string[] args)
        {



            string var = "We learn CSharp, Welcome!";





            // Length
            Console.WriteLine(var.Length + "\n");


            // ToUpper, ToLower
            Console.WriteLine(var.ToUpper() + " " + var.ToLower() + "\n");





            // Concat
            Console.WriteLine(String.Concat(var, " Hello World") + "\n");






            // Compare, CompareTo
            Console.WriteLine(var.CompareTo("Hello World") + "\n");  // length var > length Hello World

            Console.WriteLine(String.Compare(var, "Hello World", true) + "\n"); // true ise karşılaştırmada büyük küçük harf göz ardı edilir






            // Contains
            Console.WriteLine(var.Contains("CSharp"));
            Console.WriteLine(var.EndsWith("qst"));
            Console.WriteLine(var.StartsWith("We") + "\n");








            // IndexOf
            Console.WriteLine(var.IndexOf("CSharp"));   // Starts at 9
            Console.WriteLine(var.LastIndexOf("p") + "\n"); // Last p at 14








            // Insert
            Console.WriteLine(var.Insert(0, "Hi! ") + "\n");







            // PadLeft, PadRight
            Console.WriteLine(var + var.PadLeft(30));  // var 25 karakter olduğu için araya 5 boşluk ekledi
            Console.WriteLine(var.PadRight(35, 'x'));  // var 25 karakter olduğu için sağa 10 tane x ekledi










            // Remove
            Console.WriteLine(var.Remove(20)); // 20. indeksten sonrasını sildi
            Console.WriteLine(var.Remove(0,5)); // 0. indeksten sonra 5 karakter sildi










            // Replace
            Console.WriteLine(var.Replace("CSharp", "CPP"));









            // Split
            Console.WriteLine(var.Split(' ')[1]);  // stringi ' ' karakterinden ayırıp diziye aktardı ['We', 'learn', ...]











            // Substring
            Console.WriteLine(var.Substring(4)); // 4. indeksten itibaren getir
            Console.WriteLine(var.Substring(4,6)); // 4. indeksten itibaren 6 karakter getirir



        }
    }
}
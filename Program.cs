using System;




namespace ptt
{









    class Program
    {










        // Call By Reference
        static int AddAndSum(ref int n1, ref int n2)
        {
            n1+=1;
            n2+=1;

            return n1+n2;
        }
        // Call By Reference























        static void Main(string[] args)
        {









            // Call By Reference

            int x = 4;
            int y = 3;


            int res = AddAndSum(ref x, ref y);

            Console.WriteLine(res);
            Console.WriteLine(x + " " + y );

            // Call By Reference











           
        }
    }
}
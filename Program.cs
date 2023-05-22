using System;




namespace ptt
{

    // Extension
    public static class ext
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }



        public static string RemoveWhiteSpaces(this string param)
        {
            string[] array = param.Split(" ");
            
            return string.Join("", array);
        }



        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }



    }
    // Extension







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














        // Out Parameter
        static void Sum(int a, int b, out int sum)
        {
            sum = a + b;
        }
        // Out Parameter












        // Overloading
        static void print(string data)
        {
            Console.WriteLine(data);
        }

        static void print(int data)
        {
            Console.WriteLine(data);
        }
        // Overloading












        // Recursion
        static int Expo(int num, int power)
        {
            if(power<2)
                return num;

            return Expo(num, power-1) * num;
        }
        // Recursion
















        






















        static void Main(string[] args)
        {





            // Call By Reference


            // int x = 4;
            // int y = 3;


            // int res = AddAndSum(ref x, ref y);

            // Console.WriteLine(res);
            // Console.WriteLine(x + " " + y );


            // Call By Reference



















            
            // Out Parameter


        //     string num = "999";

        //     bool result = int.TryParse(num, out int outNum);

        //     if (result)
        // {            
        //         Console.WriteLine("Successfully!!!");
        //         Console.WriteLine(outNum);
        // }

        //     else
        //         Console.WriteLine("Failed!!!"); 






        //     Sum(5,3, out int res);

        //     Console.WriteLine(res);


            // Out Parameter

























            // Overloading


            // int state = 999;
            // string state2 = "Hello";

                                            
            // print(state);
            // print(state2);


            // Overloading


           






















            // Recursion


            // Console.WriteLine(Expo(2,4));


            // Expo(2,4)
            // -> 2 * Expo(2,3) 
            //        -> 2 * Expo(2,2)            ====> 2 * 2 * 2 * 2
            //               -> 2 * Expo(2,1)      
            //                      -> 2 


            // Recursion

























            // Extension


            // string variable = "eray öz";

            // bool result = variable.CheckSpaces();

            // Console.WriteLine(result);

            // if(result)
            //     Console.WriteLine(variable.RemoveWhiteSpaces());


            // Console.WriteLine(variable.MakeUpperCase());                


            // Extension




        }
    }
}

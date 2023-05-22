using System;


namespace console
{



    class Program
    {




        static void Main(string[] args)
        {










            // Implicit Conversion (Bilinçsiz)




            // byte a = 5;

            // sbyte b = 30;

            // short c = 10;

            // int d = a+b+c;       


            // Console.WriteLine("d:"+d);


            // long h = d;     

            // float i = h;

            // Console.WriteLine("i:"+i);



            // string e = "zikriye";

            // char f = 'k';

            // object g = e +f+d;

            // Console.WriteLine("g:"+g);















            // Explicit Conversion (Bilinçli)




            // float w = 10.3f;

            // int v = (int)w;

            // Console.WriteLine("v:"+v);



            // int xx = 6;

            // string yy = xx.ToString();

            // Console.WriteLine("yy:"+yy);


            // string zz = 12.5f.ToString();

            // Console.WriteLine("zz:"+zz);



















            // Try Catch Finally


            // try
            // {
            //     Console.WriteLine("Enter Number:");
            //     int n1 = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Entered Number:"+n1);

            // }
            // catch(Exception ex)
            // {
            //     Console.WriteLine("Error: " + ex.Message.ToString());
            // }
            // finally
            // {
            //     Console.WriteLine("Done...");
            // }






















            // Ternary

            // int time = DateTime.Now.Hour;

            
            // string res = time>=6 && time<11 ? "Morning" : time<=18 ? "Good Day" : "Nightyy";

            // Console.WriteLine(res);
























            // Switch Case


            // int month = DateTime.Now.Month;



            // switch (month)
            // {
            //     case 12:
            //     case 1:
            //     case 2:
            //         Console.WriteLine("Winter");
            //         break;


            //     case 3:
            //     case 4:
            //     case 5:
            //         Console.WriteLine("Spring");
            //         break;


            //     case 6:
            //     case 7:
            //     case 8:
            //         Console.WriteLine("Summer");
            //         break;


            //     case 9:
            //     case 10:
            //     case 11:
            //         Console.WriteLine("Fall");
            //         break;


            //     default:
            //         break;                                                            
            // }





























            // string s = new String('s', 3)  -> sss






            // foreach


            // string[] cars = {"BMW", "Ford", "Toyota", "Nissan"};


            // foreach (var item in cars)
            // {
            //     Console.Write(item + " ");
            // }


























            // Array


            // string[] colors = new string[5];
            // colors[0] = "Black";


            // string[] pet = {"cat", "dog", "bird", "hamster"};

            // int[] arr;
            // arr = new int[3];
            // arr[2] = 25;

            // Console.WriteLine(colors[0] + "\n" + arr[1] + "\n" + pet[3]);










            // int[] nums = {4, 1, 7, 2, 12, 11, 12, 13, 20, 5};

            // Array.Sort(nums);

            // Console.WriteLine("Sorted Array");
            // foreach(var n in nums)
            // {
            //     Console.Write(n + ",");
            // }




            // Console.WriteLine("\n\n");




            // Console.WriteLine("Cleared Array");

            // Array.Clear(nums, 2, 2);                 // ikinci indeksten itibaren iki elemanı sildi

            //  foreach(var n in nums)
            // {
            //     Console.Write(n + " ");
            // }




            // Console.WriteLine("\n\n");




            // Console.WriteLine("Reversed Array");

            // Array.Reverse(nums);

            //  foreach(var n in nums)
            // {
            //     Console.Write(n + " ");
            // }




            // Console.WriteLine("\n\n");




            // Console.WriteLine("Index Of Array");

            // int ix = Array.IndexOf(nums, 20);

            // Console.WriteLine("Index Of 20 is " + ix);




            // Console.WriteLine("\n\n");




            // Console.WriteLine("Resize");

            // Array.Resize<int>(ref nums, 9);

            //   foreach(var n in nums)
            // {
            //     Console.Write(n + " ");
            // }









        }
    }
}

using System;

namespace ProductandLcmKata2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Class1 Manager = new Class1();
            

            int[,] a = new int[3,2] { {1,1} ,{0,0} ,{13,91}};
            Console.WriteLine( Manager.ProductandLcm(a));
          
            
        }
    }
}

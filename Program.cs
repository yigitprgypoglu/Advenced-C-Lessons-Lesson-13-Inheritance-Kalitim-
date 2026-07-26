using System;


namespace C_3
{
    internal class Program
    {

        static int Main(string[] args)
        {
           //Inheritance(Kalitim-Miras)
            Computer legion5pro=new Computer();

            legion5pro.CPU = "amd ryzen 9";
            legion5pro.RAM = "32gb";
            legion5pro.GPU = "RTX 4070TI";
            legion5pro.price = "90k";
            legion5pro.quantity = 1;
            legion5pro.productname = "Legion 5 pro";


            legion5pro.WriteInfos();

            Console.ReadLine();
            return 0;
        }

       
    }
   
}

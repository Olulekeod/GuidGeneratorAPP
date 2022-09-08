using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            for (int i = 0; i < 500; i++)
            {
                Guid obj = Guid.NewGuid();
                Console.WriteLine(obj.ToString());
                //Console.ReadLine();
                //return -1;
                //Console.WriteLine(i);
            }



        }
    }
}
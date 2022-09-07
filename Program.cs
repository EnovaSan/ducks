using System;
using System.Collections.Generic;

namespace кря
{
    class Program : Construct
    {
        public static void Main(string[] args)
        {

            List<string> Ducks = new List<string>{"живая", "плюшевая", "пластмассовая" };

            foreach(var duck in Ducks)
            {
                if (duck == "живая")
                {
                    infoDuck(duck, "кря");
                }
                else
                {
                    infoDuck(duck, "лежит, не двигается");
                }
            }

            Console.ReadLine();
        }
    }
}

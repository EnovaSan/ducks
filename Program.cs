using System;
using System.Collections.Generic;

namespace кря
{
    abstract class DuckSound
    {
        public abstract void Activity();

        public void DuckInfo()
        {
            Console.WriteLine(GetType().Name);
        }

    }

    class ScotlandDuck : DuckSound
    {
        public override void Activity()
        {
            Console.WriteLine("квак-квак\n");
        }
    }

    class ItalianDuck : DuckSound
    {
        public override void Activity()
        {
            Console.WriteLine("ква-ква\n");
        }
    }

    class DanishDuck : DuckSound
    {
        public override void Activity()
        {
            Console.WriteLine("рэп-рэп\n");
        }
    }

    class RussianDuck : DuckSound
    {
        public override void Activity()
        {
            Console.WriteLine("кря-кря\n");
        }
    }

    class UndeadDuck : DuckSound
    {
        public override void Activity()
        {
            Console.WriteLine("тоби конец!");
        }
    }

    class Sound
    {
        public void Activity(DuckSound duckSound)
        {
            duckSound.Activity();
        }

        public void DuckInfo(DuckSound duckSound)
        {
            duckSound.DuckInfo();
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Sound sound = new Sound();

            DuckSound[] ducks = { new ScotlandDuck(), new ItalianDuck(), new RussianDuck(), new DanishDuck(), new UndeadDuck() };

            foreach (var item in ducks)
            {
                sound.DuckInfo(item);
                sound.Activity(item);
            }
           
        }
    }
}
 
      
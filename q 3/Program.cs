using System;

namespace q_3
{
    public abstract class PatternPrinter
    {
        private int patternLength;
        public PatternPrinter(int patternLength)
        {
            this.patternLength = patternLength;
        }
        public void Print()
        {
            Random rnd = new Random();
            int specialIndex = rnd.Next(patternLength);
            for (int i = 0; i < patternLength; i++)
            {
                if (i == specialIndex)
                    PrintSpecial();
                else
                {
                    int roll = rnd.Next(2); // either 0 or 1
                    if (roll == 0) PrintNormal();
                    else PrintVariant();
                }

            }
        }
        public abstract void PrintNormal();
        public abstract void PrintVariant();
        public abstract void PrintSpecial();
    }
    public class RiverPattern : PatternPrinter
    {
        
        public RiverPattern(int patternLength) : base(patternLength) { }
       
        public override void PrintNormal()
        {
            Console.WriteLine("***O   O***");
            Console.WriteLine("***O   O***");
            Console.WriteLine("***O   O***");
            Console.WriteLine("***O   O***");
        }
        public override void PrintVariant()
        {
            Console.WriteLine("**O   O****");
            Console.WriteLine("*O   O*****");
            Console.WriteLine("**O   O****");
            Console.WriteLine("***O   O***");
        }
        public override void PrintSpecial()
        {
            Console.WriteLine("**O    O***");
            Console.WriteLine("*O      O * *");
            Console.WriteLine("*O  OO   O*");
            Console.WriteLine("*O  O    O*");
            Console.WriteLine("**O     O**");
        }
    }
    public class Program
    {
        public static void Main()
        {
            RiverPattern river = new RiverPattern(10);
            river.Print();
        }
    }
}

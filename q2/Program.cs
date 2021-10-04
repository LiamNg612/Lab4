using System;

namespace q2
{
    class Program
    {
        public interface IDice
        {
            int Next();
        }
        public class DiceEvaluator
        {
            static public void Evaluate(IDice d)
            {
                double sum = 0f;
                int[] times = new int[7];
                for (int i = 0; i < 100; i++)
                {
                    int roll = d.Next();
                    if (roll <= 0 || roll > 6)
                    {
                        Console.WriteLine("Bad dice! No evaluation done.");
                    }
                    times[roll]++;
                    sum += roll;
                }
                double average = sum / 100;
                Console.WriteLine("Dice roll average of 100 runs: {0}", average);
                Console.WriteLine("Statistics: ");
                for (int i = 1; i <= 6; i++)
                {
                    Console.WriteLine("{0} : {1}", i, times[i]);
                }
            }
        }
        public class RiggedDice : IDice
        {
            private Random rnd;
            public RiggedDice()
            {
                rnd=new Random();
            }
            public int Next()
            {

                int num;
                if (rnd.Next(1, 3)==1)
                {
                    return 6;
                }
                else
                {
                    num = rnd.Next(1, 6);
                    return num;
                }

            }
        }

        static void Main(string[] args)
        {
            
            DiceEvaluator.Evaluate(new RiggedDice());
        }
    }
}

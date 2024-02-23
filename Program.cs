using System;
namespace SelfCSharp.Chap01
{
    internal abstract class Dice
    {
        // See https://aka.ms/new-console-template for more information
        //サイコロで出る目の最大値、最小値
        public int min;
        public int max;
        //public int x;

        public Random rand = new Random();

        public Dice(int min, int max)
        {
            this.min = min;
            this.max = max;
           // this.x = x;
        }

        public abstract int roll();
    }

    internal class SixTo216 : Dice
    {
        public SixTo216(): base(1,6) { }
        public override int roll()
        {
            return rand.Next(min, max + 1); ;
        }
    }

    internal class PersonClient
    {
        static void Main(string[] args)
        {
            var d = new SixTo216();
            int sum = 0;
            int i = 1;

            //100を超えたらゲームクリア
            while(i <= 100)
            {
                int result = d.roll();
                sum += result;
                Console.WriteLine($"{i}回目　Roll {result}");
                if(sum >=100)
                {
                    Console.WriteLine($"{i}回目でゲームクリア");
                    break;
                }
                i++;
                
            }
        }
    }
}




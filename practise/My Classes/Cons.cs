namespace Cons1
{
    class Cons
    {
        public int a;
        public int b;
        public readonly gcard card;
        public const int c = 100;
        public readonly int d;

        public static int e;
        public Cons(int a, int b)
        {
            this.a = a;
            this.b = b;           
        }
        public Cons()
        {
            d = 100;
        }
        public Cons(gcard card)
        {
            this.card = card;

            if(this.card == gcard.AMD)
            {
                System.Console.WriteLine("You have choosen AMD");
            }
            else
            {
                System.Console.WriteLine("You have choosen Nvidia");
            }
        }

        
    }
}

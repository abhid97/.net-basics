namespace property
{
    class pro
    {
        private int a;
        private int b;

        public int A
        {
            /* get
             {                
                     System.Console.WriteLine("making it 100 now...");
                     while(a!=100)
                     {
                         a = a + 10;
                         System.Console.WriteLine("10 added to a");
                     }
                     return a;            
             }*/
            set
            {
                a = value;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            /* set
             {
                 b = value;
             }*/
        }

        public pro(int b)

        {
            this.b = b;
        }
    }
}

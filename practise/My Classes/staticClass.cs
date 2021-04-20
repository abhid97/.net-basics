 static class staticClass
  {
    public static void changeConsoleColor(gcard text)
    {
        if(text.Equals(gcard.AMD))
        {
            System.Console.ForegroundColor = System.ConsoleColor.Red;
            System.Console.WriteLine(text);
            System.Console.ResetColor();
        }
        else
        {
            System.Console.ForegroundColor = System.ConsoleColor.Green;
            System.Console.WriteLine(text);
            System.Console.ResetColor();
        }
    }
  }


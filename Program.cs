using System;

namespace GeradorDeSenhas
{
    class Gerador
    {
      static void Main() 
      {
        var Alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var SpecialCharacters = "'!@#$%¨&*";
        var Quantidade = 25;

        DesenharMenu();

        GetPassword.GetRandomPassword(Alphabet,SpecialCharacters, Quantidade);

        Console.SetCursorPosition(0,31);

      }
      static void DesenharMenu()
      {
        Console.Write("+");
        for(var i=0; i < 48; i++)
        {
            Console.Write("=");
        }
        Console.Write("+");

        for(var i1 = 0; i1 < 2; i1++){Console.Write(" ");}

        Console.Write("+");
        for(var i=0; i < 48; i++)
        {
            Console.Write("=");
        }
        Console.WriteLine("+");

        
        for(var i2=0; i2 < 28; i2++)
        {
            Console.Write("|");
            for(var i3=0; i3 < 48; i3++)
            {
                Console.Write(" ");
            }
            Console.Write("|");

            for(var i1 = 0; i1 < 2; i1++){Console.Write(" ");}

            Console.Write("|");
            for(var i3=0; i3 < 48; i3++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
        }
        
        Console.Write("+");
        for(var i=0; i < 48; i++)
        {
            Console.Write("=");
        }
        Console.Write("+");

        for(var i1 = 0; i1 < 2; i1++){Console.Write(" ");}

        Console.Write("+");
        for(var i=0; i < 48; i++)
        {
            Console.Write("=");
        }
        Console.WriteLine("+");
      }

    }
}

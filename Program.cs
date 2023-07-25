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
        EscreverOpcoes(3,4,Alphabet, SpecialCharacters);
        
        Console.SetCursorPosition(0,31);

      }
      static void Menu(string alphabet, string specialcharacters)
      {
        DesenharMenu();
        EscreverOpcoes(3,4,alphabet, specialcharacters);
      }
      static void DesenharMenu()
      {
        Console.Clear();
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

      static void EscreverOpcoes(int x, int y, string alphabet, string specialcharacters)
      {
        Console.SetCursorPosition(x,y);
        Console.WriteLine("[1] - Gerar senhas Alfanuméricas");
        Console.SetCursorPosition(x,y+1);
        Console.WriteLine("[2] - Gerar senhas Numéricas");
        Console.SetCursorPosition(x,y+2);
        Console.WriteLine("[3] - Gerar senhas com caracteres");
        Console.SetCursorPosition(x,y+3);
        Console.WriteLine("[4] - Gerar senhas com caracteres especiais");
        Console.SetCursorPosition(x,y+4);
        Console.WriteLine("[5] - Sair");
        Console.SetCursorPosition(x,y+6);
        Console.WriteLine("Opção:");
        Console.SetCursorPosition(x+10,y+6);
        
        var option_menu = int.Parse(Console.ReadLine());

        switch(option_menu)
        {
            case 1:
            {
                Console.Clear();
                DesenharMenu();
                Console.SetCursorPosition(x,y);
                Console.WriteLine("Quantas senhas deseja gerar?");
                Console.SetCursorPosition(x,y+2);
                Console.WriteLine("Opção:");
                Console.SetCursorPosition(x+10,y+2);
                var QtdSenhas = int.Parse(Console.ReadLine());
                GetPassword.GetRandomPassword(alphabet,specialcharacters,QtdSenhas);
                Menu(alphabet, specialcharacters);
                break;
            }
            case 2:break;
            case 3:break;
            case 4:break;
            default:Console.SetCursorPosition(x,y+6); Console.WriteLine("Programa finalizado!");break;
        }
      }

    }
}

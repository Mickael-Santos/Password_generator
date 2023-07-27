

namespace GeradorDeSenhas
{
    public class WriteRead
    {
        public static void SaveInfos(int x, int y, string texto)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("<<Informe o local onde deseja salvar>>");
            Console.SetCursorPosition(x, y+1);
            Console.WriteLine("<<Utilize / ao informar>>");
            Console.SetCursorPosition(x, y+2);
            var path = Console.ReadLine();
            Console.SetCursorPosition(x, y+3);
            Console.WriteLine("<<Qual o nome do arquivo?>>");
            Console.SetCursorPosition(x, y+4);
            var filename = Console.ReadLine();
            var filepath = $"{path}/{filename}.txt";
            using(var sw = new StreamWriter(filepath))
            {
                sw.Write(texto);
            }
            Console.SetCursorPosition(x, y+5);
            Console.WriteLine($"Arquivo salvo com sucesso em {filepath}");
        }
    }
}


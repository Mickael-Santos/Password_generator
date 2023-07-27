
using System.Text;

namespace GeradorDeSenhas
{
    public class GetPassword
    {
        public static void GetRandomPassword(string alphabet, string specialcharacters, int quantidade = 0)
        {
            if (quantidade <= 25)
            {
                StringBuilder sb = new StringBuilder();
                for (var senhas = 0; senhas < quantidade; senhas++)
                {
                    Gerador.AnimLoading(55,27);
                    var indexY = senhas + 2;
                    var id = senhas + 1;
                    Console.SetCursorPosition(53, indexY);
                    Console.Write("| ");
                    sb.Append("| ");
                    Console.Write(id);
                    sb.Append(id);
                    Console.Write("| ");
                    sb.Append("| ");
                    DateTime data = DateTime.Now;
                    Console.Write(data.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")));
                    sb.Append(data.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")));
                    Console.Write("| ");
                    sb.Append("| ");
                    for (var i = 0; i < 4; i++)
                    {
                        Console.Write(GetRandomChar(alphabet));
                        sb.Append(GetRandomChar(alphabet));
                    }
                    for (var i2 = 0; i2 < 4; i2++)
                    {
                        Console.Write(GetRandomNumber(0, 10));
                        sb.Append(GetRandomNumber(0, 10));
                    }
                    Console.Write(GetRandomSpecialChar(specialcharacters));
                    sb.Append(GetRandomSpecialChar(specialcharacters));
                    Console.Write(" |\n");
                    sb.Append(" |\n");

                }
                var arquivo = sb.ToString();
                WriteRead.SaveInfos(2,9,arquivo);
            }
            else
            {

                Console.SetCursorPosition(54, 2);
                Console.WriteLine("Essa quantidade de senhas");
                Console.SetCursorPosition(54, 3);
                Console.WriteLine("Não pode ser impressa!");
            }

        }

        public static void GetNumberPassword(int quantidade)
        {
            if (quantidade <= 25)
            {
                StringBuilder sb = new StringBuilder();
                for (var senhas = 0; senhas < quantidade; senhas++)
                {
                    Gerador.AnimLoading(55,27);
                    var indexY = senhas + 2;
                    var id = senhas + 1;
                    Console.SetCursorPosition(53, indexY);
                    Console.Write("| ");
                    sb.Append("| ");
                    Console.Write(id);
                    sb.Append(id);
                    Console.Write("| ");
                    sb.Append("| ");
                    DateTime data = DateTime.Now;
                    Console.Write(data.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")));
                    sb.Append(data.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")));
                    Console.Write("| ");
                    sb.Append("| ");
                    for (var i2 = 0; i2 < 8; i2++)
                    {
                        Console.Write(GetRandomNumber(0, 10));
                        sb.Append(GetRandomNumber(0, 10));
                    }
                    Console.Write(" |\n");
                    sb.Append(" |\n");

                }
                var arquivo = sb.ToString();
                WriteRead.SaveInfos(2,9,arquivo);
            }
            else
            {

                Console.SetCursorPosition(54, 2);
                Console.WriteLine("Essa quantidade de senhas");
                Console.SetCursorPosition(54, 3);
                Console.WriteLine("Não pode ser impressa!");
            }
        }

        public static void GetCharPassword(string alphabet, int quantidade)
        {
            if (quantidade <= 25)
            {
                StringBuilder sb = new StringBuilder();
                for (var senhas = 0; senhas < quantidade; senhas++)
                {
                    Gerador.AnimLoading(55,27);
                    var indexY = senhas + 2;
                    var id = senhas + 1;
                    Console.SetCursorPosition(53, indexY);
                    Console.Write("| ");
                    sb.Append("| ");
                    Console.Write(id);
                    sb.Append(id);
                    Console.Write("| ");
                    sb.Append("| ");
                    DateTime data = DateTime.Now;
                    Console.Write(data.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")));
                    sb.Append(data.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")));
                    Console.Write("| ");
                    sb.Append("| ");
                    for (var i = 0; i < 8; i++)
                    {
                        Console.Write(GetRandomChar(alphabet));
                        sb.Append(GetRandomChar(alphabet));
                    }
                    Console.Write(" |\n");
                    sb.Append(" |\n");

                }
                var arquivo = sb.ToString();
                WriteRead.SaveInfos(2,9,arquivo);
            }
            else
            {

                Console.SetCursorPosition(54, 2);
                Console.WriteLine("Essa quantidade de senhas");
                Console.SetCursorPosition(54, 3);
                Console.WriteLine("Não pode ser impressa!");
            }
        }

        public static void GetSpecialCharPassword(string specialcharacters, int quantidade)
        {
            if (quantidade <= 25)
            {
                StringBuilder sb = new StringBuilder();
                for (var senhas = 0; senhas < quantidade; senhas++)
                {
                    Gerador.AnimLoading(55,27);
                    var indexY = senhas + 2;
                    var id = senhas + 1;
                    Console.SetCursorPosition(53, indexY);
                    Console.Write("| ");
                    sb.Append("| ");
                    Console.Write(id);
                    sb.Append(id);
                    Console.Write("| ");
                    sb.Append("| ");
                    DateTime data = DateTime.Now;
                    Console.Write(data.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")));
                    sb.Append(data.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")));
                    Console.Write("| ");
                    sb.Append("| ");
                    for (var i = 0; i < 8; i++)
                    {
                        Console.Write(GetRandomSpecialChar(specialcharacters));
                        sb.Append(GetRandomSpecialChar(specialcharacters));
                    }
                    Console.Write(" |\n");
                    sb.Append(" |\n");

                }
                var arquivo = sb.ToString();
                WriteRead.SaveInfos(2,9,arquivo);
            }
            else
            {

                Console.SetCursorPosition(54, 2);
                Console.WriteLine("Essa quantidade de senhas");
                Console.SetCursorPosition(54, 3);
                Console.WriteLine("Não pode ser impressa!");
            }
        }

        private static char GetRandomChar(string s)
        {
            Random rand = new Random();
            var index = rand.Next(0, s.Length);
            var character = s[index];

            return character;
        }

        private static char GetRandomSpecialChar(string s)
        {
            Random rand = new Random();
            var index = rand.Next(0, s.Length);
            var character = s[index];

            return character;
        }

        private static int GetRandomNumber(int i, int f)
        {
            Random rand = new Random();
            var Random_number = rand.Next(i, f);
            return Random_number;
        }
    }
}



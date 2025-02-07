
namespace MyencryptAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Welcome\n" +
            "/encrypt?input= \n" +
            "/decrypt?input=  ");

            app.MapGet("/encrypt", (string input) => Encrypto(input));
            app.MapGet("/decrypt", (string input) => Decrypt(input));
            app.Run();

            string Encrypto(string input)
            {
                string encrypted = Encrypt(input, 3);
                return $"Encrypt:  {encrypted}  ";
            }

            string Decrypt(string input)
            {
                string decrypted = Encrypt(input, -3);
                return $"Decrypt:  {decrypted}  ";
            }
        }

        public static string Encrypt(string input, int shift)
        {
            string result = "";

            foreach (char letter in input)
            {
                if (char.IsLetter(letter))
                {
                    if (char.IsLower(letter))
                    {
                        char shifted = (char)((letter - 'a' + shift) % 26 + 'a');
                        result += shifted;
                    }
                    else if (char.IsUpper(letter))
                    {
                        char shifted = (char)((letter - 'A' + shift) % 26 + 'A');
                        result += shifted;
                    }
                }
                else if (char.IsDigit(letter))
                {
                    char shifted = (char)((letter - '0' + shift) % 10 + '0');
                    result += shifted;
                }
                else
                {
                    result += letter;
                }
            }
            return result;
        }

        public static string Decrypt(string input, int shift)
        {
            return Encrypt(input, -shift);
        }
    }
}


using Encryptolibrary;


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

            app.MapGet("/encrypt", (string input) => Encrypt(input));
            app.MapGet("/decrypt", (string input) => Decrypt(input));
            app.Run();

            string Encrypt(string input)
            {
                Enkrypto encrypt = new Enkrypto();
                string encrypted = encrypt.Encrypt(input, 3);
                return $"Encrypt:  {encrypted}  ";
            }

            string Decrypt(string input)
            {
                Enkrypto decrypt = new Enkrypto();
                string decrypted = decrypt.Decrypt(input, 3);
                return $"Decrypt:  {decrypted}  ";
            }
        }
    }
}

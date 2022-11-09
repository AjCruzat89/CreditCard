using System; 

namespace CreditCard
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number :");
            Console.ReadLine();

            var compression = new Compression();
            compression.NumberCC();
            Console.ReadLine();

            var encrypt = new Encryption();
            encrypt.Encrypt();
            Console.ReadLine();

            var store = new Storing();
            store.Store();
            Console.ReadLine();

        }
    }

    public interface ICardNumber
    {
        void NumberCC();
    }

    public class Compression : ICardNumber
    {
        public void NumberCC()
        {
            Console.WriteLine("The data is successfully compressed..");
            Console.WriteLine("Press enter to continue");
        }
    }

    public class Encryption : Compression
    {
        public void Encrypt()
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            Console.WriteLine("Please input a number for encryption");
            var str = Console.ReadLine();
            var encryptedNumber = (key);
            Console.WriteLine($"Encrypted Number = {encryptedNumber}");
            Console.WriteLine("Press enter key to store into cloud");
        }
    }

    public class Storing : Encryption
    {
        public void Store()
        {
            Console.WriteLine("Successfully stored into cloud...");
        }
    }
}
namespace TasKagıtMakas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string oyuncu1;
            string oyuncu2;

            Console.WriteLine("Oyuncu1 secimini giriniz");
            oyuncu1 = Console.ReadLine();
            Console.WriteLine("Oyuncu2 secimini giriniz");
            oyuncu2 = Console.ReadLine();

            if (oyuncu1 == "tas")
            {
                if (oyuncu2 == "makas")
                    Console.WriteLine("oyuncu1 kazandı");
                if (oyuncu2 == "kagıt")
                    Console.WriteLine("oyuncu2 kazandı");
                if (oyuncu2 == "tas")
                    Console.WriteLine("berabere");
            }
            else if (oyuncu1 == "makas")
            {
                if (oyuncu2 == "tas")
                    Console.WriteLine("oyuncu2 kazandı");
                if (oyuncu2 == "makas")
                    Console.WriteLine("berabere");
                if (oyuncu2 == "kagıt")
                    Console.WriteLine("oyuncu1 kazandı");
            }
            else  if (oyuncu1 == "kagıt")
            {
                if (oyuncu2 == "tas")
                    Console.WriteLine("oyuncu1 kazandı");
                if (oyuncu2 == "makas")
                    Console.WriteLine("oyuncu2 kazandı");
                if (oyuncu2 == "kagıt")
                    Console.WriteLine("berabere");
            }

        }
    }
}
using System;

namespace Lica_Andrei
{
    class Program  // o clasa care are membrii si metode
    {
        static void Main(string[] args) //metoda main care se va rula prima la executare
        {
            Console.WriteLine("Hello World!"); //o instructiune / statement
            Program obiect = new Program();
            string[] argProvizoriu = { "1" };
            if (args.Length == 0)// in tutorial a bagat argumente la main prin consola. nu stiu cum fac asta in windows asa ca am reapelat main cu inca un argument
            {
                Main(argProvizoriu);
            }
               
            obiect.Print();
            
        }
        void Print()
        {
            Console.WriteLine("am afisat alt mesaj in afara de hello world yey");
        }
    }
}

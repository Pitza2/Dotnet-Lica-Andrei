using System;

namespace Lica_Andrei
{
    class Program  // o clasa care are membrii si metode
    {
        static void Main(string[] args) //metoda main care se va rula prima la executare
        {
            //Program obiect = new Program();
            //if (args.Length != 0)// in tutorial a bagat argumente la main prin consola. nu stiu cum fac asta in windows asa ca am reapelat main cu inca un argument
            //{
            //    Console.WriteLine(args[0]); //o instructiune / statement
            //}
            //else
            //{
            //    Console.WriteLine("hello world");// daca args are lungime 0 atunci afiseaza hello world si citeste de la tastatura un string pentru un nou args
            //    string[] argProvizoriu = new string[10];// variabila de tip vector de string-uri I guess, key word-ul new apeleaza constructorul, initializand cu o valoare default
            //    argProvizoriu[0] = Console.ReadLine();

            //    Main(argProvizoriu);

            //}

            //obiect.Print();//se printeaza la final de 2 ori, prima oara din main-ul apelat cu argProvizoriu si apoi din main-ul original
            int[] V = { 1, 2, 3, 4, 5 };
            int[] Q = V;
            Q[0] = 10;
            Console.WriteLine(V[0]);
            double a = double.NaN;
            Console.WriteLine(double.IsNaN(a));

            double x = 50.5;
            Console.WriteLine(Math.Round(x)+" "+Math.Round(x,0,MidpointRounding.AwayFromZero)+" "+Math.Truncate(x));//cateva metode din clasa Math care rotunjesc in diferite moduri o variabila cu floating point

            double y = 1000;
            Console.WriteLine(Math.Max(x,y)+" "+Math.Sign(x-y)+" "+Math.Sign(y-x));


            string propoz = "come mister tally man tally me banana";
            Console.WriteLine($"lungime propozitie: {propoz.Length}");
            propoz += " daylight come and me want go home";
            Console.WriteLine($"lungime propozitie: {propoz.Length}");

            Console.WriteLine(String.Join('-',propoz.Split(' ')));

        }
        void Print()
        {
            Console.WriteLine("am afisat alt mesaj in afara de hello world yey");
        }
    }
}

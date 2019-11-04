using HelloWorld.Model;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //VALUE TYPE
            int numeroIntero; // var pippo = 2;
            float numeroConLaVirgola32;
            double numeroConLaVirgola64;
            bool valoreLogico;
            char carattere;
            decimal valoreDecimale;
            //esempio
            int i = 10;
            int j = i;

            Console.WriteLine(i);
            Console.WriteLine(j);

            i = 5;

            Console.WriteLine(i);
            Console.WriteLine(j);


            // REFERENCE TYPE
            string insiemeCaratteri; //tende a mantenere una coerenza in spazi ristretti

            //esempio

            string stringa1="la mia casa è bella";
            string stringa2=stringa1;
            //console...
            stringa1 = "la mia casa è brutta";
            //console...
            //fine

            object oggetto;

            Person luca= new Person("Luca", "Lippi");
            luca.età = 18; //pubblic, quindi posso cambiare le var

            Console.WriteLine(luca.Anagrafica());

            Person giovanni = luca;
            giovanni.nome = "Giovanni"; //puntano alla stessa zona di memoria quindi anche luca diventa "giovanni"

            Console.WriteLine(luca.Anagrafica());
            Console.WriteLine(giovanni.Anagrafica()); 




        }
    }
}

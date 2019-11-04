using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Model
{
    class Person
    {   //variabili di classe
        public string name;
        public string cognome;
        public int età;
        public string sesso;
        public int altezza;
        public double peso;
        public Person(string nome, string cognome)
        {
            this.name = nome;
            this.cognome = cognome;
            this.sesso = "sconosciuto";
        }

        public Person(string nome)
        {

        }

        public Person() //costruttore vuoto, viene creato di default
        {
        }

        public string Anagrafica()
        {
            string anagrafica = this.name + this.cognome;
            return anagrafica;
        }

        public Person(string nome, string cognome, int altezza, double peso)
        {
            this.name = nome;
            this.cognome = cognome;
            this.altezza = altezza;
            this.peso = peso;
        }




    }
}

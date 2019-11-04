☺using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Model
{
    class Person
    {   //variabili di classe
        public string nome;
        public string cognome;
        public int età;
        public string sesso;
        public int altezza;
        public double peso;
        public Person(string nome, string cognome)
        {
            this.nome = nome;
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
            string anagrafica = this.nome + this.cognome;
            return "anagrafica";
        }


    }
}

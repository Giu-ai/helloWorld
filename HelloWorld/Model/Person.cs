using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Model
{
    class Person
    {   //variabili di classe
        public string name;
        public string surname;
        public int age;
        public string sesso;
        public int altezza;
        public double peso;
        public Person(string nome, string cognome)
        {
            this.name = nome;
            this.surname = cognome;
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
            string anagrafica;
            if (BMI() != -1)
            {
                anagrafica = this.name + this.surname + "il suo BMI è:" + BMI();
            }
            else
            {
                anagrafica = this.name + this.surname + "BMI NON DISPONIBILE";
            }
            return anagrafica;
        }

        public Person(string nome, string cognome, int altezza, double peso)
        {
            this.name = nome;
            this.surname = cognome;
            this.altezza = altezza;
            this.peso = peso;
        }

        public double BMI()
        {
            if (this.altezza != 0 && this.peso != 0)
            {
                double h = (double)this.altezza / 100;
                double bmi = this.peso / (h * h);
                return bmi;
            }
            else
            {
                return -1;
            }
        }





}
}

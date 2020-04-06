using System;
namespace Laboratorio3AntoniaCarrizo
{
    public class Person
    {
        //atributos
        private string rut;
        private string name;
        private string lastname;
        private string datebirth;
        private string nationality;

        //constructor
        public Person(string rut, string name, string lastname, string datebirth, string nationality)
        {
            this.rut = rut;
            this.name = name;
            this.lastname = lastname;
            this.datebirth = datebirth;
            this.nationality = nationality;
        }
        //Constructor vacio
        public Person()
        {

        }

        //metdos para retornar los valores


        public string Rut ()
        {
            return rut;
        }

        public string Name()
        {
            return name;
        }

        public string Lastname()
        {
            return lastname;
        }

        public string Datebirth()
        {
            return datebirth;
        }

        public string Nationality()
        {
            return nationality;
        }

        
    }
}

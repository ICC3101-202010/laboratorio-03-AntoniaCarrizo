using System;
using System.Collections.Generic;

namespace Laboratorio3AntoniaCarrizo
{
    public class Client:Person
    {
        //lista de clientes
        private List<Client> listclient = new List<Client>();
        //Constructor
        public Client(string rut, string name, string lastname, string datebirth, string nationality): base(rut,name,lastname,datebirth,nationality)
        {
            
        }
        public Client()
        {

        }
       

        public bool Agregarcliente(Client client)
        {
            for (int a = 1; a < listclient.Count;)
            {
                if (listclient[a].Rut() == client.Rut())
                {
                    Console.WriteLine("El cliente ya estaba agregado");
                    return false;
                }
                else
                {
                    a++;
                }

            }
            listclient.Add(client);
            return true;

        }

        public void VerClientes()
        {
            int n = 0;
            for (int i = 0; i < listclient.Count; i++)
            {   
                Console.WriteLine(n+") Rut: "+listclient[i].Rut() + "- Nombre:" + listclient[i].Name()+"- Apellido: " + listclient[i].Lastname()+ "- Nacimiento: " + listclient[i].Datebirth()+ "- Nacionalidad: " + listclient[i].Nationality());
                n++;
            }
        }



    }
}

using System;
using System.Collections.Generic;

namespace Laboratorio3AntoniaCarrizo
{
    public class Purchase
    {
        private DateTime fechahora;

        private List<Purchase> todasCompras = new List<Purchase>();
        Product pp = new Product();

       
        public Purchase(Client client, Employee employee, List<Product> productoscomprados, DateTime fechahora)
        {

        }
        
        public Purchase()
        {

        }
        

        public void RealizarCompra(string sino,List<Product>carro,Client client,Employee employee)
        {
            /* En esta parte tengo que ver como traer la lista de productos del carro de compras del cliente
             * Tambien hay que agregar el cliente y el empleado s
             */

            if (sino == "si" || sino == "Si" || sino == "sI" || sino == "SI")
            {
                
                Purchase purchase = new Purchase(client,employee, carro, DateTime.Now);
                todasCompras.Add(purchase);
                
            }
            else
            {
                Console.WriteLine("Compra NO realizada");

            }
            
        }
        

        public void VerTodaslascompras()
        {

            int n = 1;
            for (int i = 0; i < todasCompras.Count; i++)
            {
                Console.WriteLine(n + ") " );
                n++;
            }
            
        }


    }
}

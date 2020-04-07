using System;
using System.Collections.Generic;

namespace Laboratorio3AntoniaCarrizo
{
    public class Purchase
    {
        private DateTime fechahora;

        private List<Purchase> todasCompras = new List<Purchase>();
        private Product pp = new Product();
        private Client client = new Client();
        private Employee employee = new Employee();
        private List<Product> productoscarro = new List<Product>();


        public Purchase(Client client, Employee employee, List<Product> productoscarro, DateTime fechahora)
        {
            this.fechahora = fechahora;
        }
        
        public Purchase()
        {

        }
        public List<Purchase> TodasCompras()
        {
            return todasCompras;
        }
        public Client Client()
        {
            return client;
        }
        public Employee Employee()
        {
            return employee;
        }
        public DateTime Fechahora()
        {
            return fechahora;
        }
        public List<Product> Productoscarro()
        {
            return productoscarro;
        }




        public void RealizarCompra(List<Product>carro,Client client,Employee employee)
        {
               
                Purchase purchase = new Purchase(client,employee, carro, DateTime.Now);
                todasCompras.Add(purchase);      
        }
        

        public void VerTodaslascompras()
        {
            if (todasCompras.Count > 0)
            {
                
                int n = 1;
                for (int i = 0; i < todasCompras.Count; i++)
                {
                    Console.WriteLine(n + ") \nCliente: Nombre: " + todasCompras[i].Client().Name() + " ; Apellido: " + todasCompras[i].Client().Lastname() + " ; Rut: " + todasCompras[i].Client().Rut());
                    Console.WriteLine("Empleado: Nombre: " + todasCompras[i].Employee().Name() + " ; Apellido: " + todasCompras[i].Employee().Lastname() + " ; Rut: " + todasCompras[i].Employee().Rut());
                    Console.WriteLine("Fecha Compra: " + todasCompras[i].Fechahora().Date + "- Hora: " + todasCompras[i].Fechahora().Hour);
                    Console.WriteLine("Productos Comprados: \n");
                    n++;

                    
                    int l = 1;
                    for (int a = 0; a < todasCompras[i].Productoscarro().Count; a++)
                    {
                        Console.WriteLine(l + ")");
                            //Console.WriteLine(l + ") " + todasCompras[i].Productoscarro()[a].NameProduct() + "-" + todasCompras[i].Productoscarro()[a].Brand() + "- Cantidad: " + todasCompras[i].Productoscarro()[a].Stock());
                            l++;
                    }

                   

                }
                
            }
            else
            {
                Console.WriteLine("No hay compras");
            }
        }


    }
}

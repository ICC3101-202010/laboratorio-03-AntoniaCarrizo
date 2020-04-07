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
            this.Cli = client;
            this.Empl = employee;
            this.Productoscarro = productoscarro;


        }
        
        public Purchase()
        {

        }
        public List<Purchase> TodasCompras()
        {
            return todasCompras;
        }
        public Client Cli
        {
            get
            {
                return this.client;
            }
            set
            {
                this.client = value;

            }
        }
        public Employee Empl
        {
            get
            {
                return this.employee;
            }
            set
            {
                this.employee = value;

            }
        }
        public DateTime Fechahora()
        {
            return fechahora;
        }
        public List<Product> Productoscarro
        {
            get
            {
                return this.productoscarro;
            }
            set
            {
                this.productoscarro = value;

            }
        }




        public void RealizarCompra(List<Product>carro,Client client,Employee employee)
        {
               
                Purchase purchase = new Purchase(client,employee, carro, DateTime.Now);
                todasCompras.Add(purchase);      
        }
        

        public void VerTodaslascompras()
        {
            //Se deberia poder ver la informacion de los elementos, pero no se muestra, sin embargo la compra SI queda guardada
            if (todasCompras.Count > 0)
            {
                Console.WriteLine("La cantidad de compras es: "+todasCompras.Count);
                int n = 1;
                for (int i = 0; i < todasCompras.Count; i++)
                {
                    Console.WriteLine(n + ") \nCliente: Nombre: " + todasCompras[i].Cli.Name() + " ; Apellido: " + todasCompras[i].Cli.Lastname() + " ; Rut: " + todasCompras[i].Cli.Rut());
                    Console.WriteLine("Empleado: Nombre: " + todasCompras[i].Empl.Name() + " ; Apellido: " + todasCompras[i].Empl.Lastname() + " ; Rut: " + todasCompras[i].Empl.Rut());
                    Console.WriteLine("Fecha Compra: " + todasCompras[i].Fechahora().Date + "- Hora: " + todasCompras[i].Fechahora().Hour);
                    Console.WriteLine("Productos Comprados: \n");
                    n++;

                    
                    int l = 1;
                    for (int a = 0; a < todasCompras[i].Productoscarro.Count; a++)
                    {
                        Console.WriteLine(l + ")");
                            Console.WriteLine(l + ") " + todasCompras[i].Productoscarro[a].NameProduct() + "-" + todasCompras[i].Productoscarro[a].Brand() + "- Cantidad: " + todasCompras[i].Productoscarro[a].Stock());
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

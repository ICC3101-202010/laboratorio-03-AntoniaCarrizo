using System;

namespace Laboratorio3AntoniaCarrizo
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Client c = new Client();
            Employee e = new Employee();
            Product p = new Product();
            Purchase r = new Purchase();

            //Agregar clientes
            for (int i = 1; i <= 30; i++)
            {
                Client c1 = new Client("195614148" + i, "Persona" + i, "Apellido" + i, "28-07-1997" + i, "Chilena" );
                c.Agregarcliente(c1);

            }
            //Agregar empleados
            for (int i = 1; i <= 10; i++)
            {
                Employee e1 = new Employee("Trabajo"+i,100000+i,"13"+i+"horas","14567842" + i, "Empleado" + i, "Apellido" + i, "28-07-200" + i, "Chilena");
                e.Agregarempleado(e1);

            }
            //Agregar productos
            for (int i = 1; i <= 10; i++)
            {
                Product p1 = new Product("Producto"+i,1000+i,50+i,"marca"+i,12345+i);
                p.AgregarProducto(p1);

            }

            while (true)
            {


                //menu
                Console.WriteLine("Opciones: \n 1)Ver clientes \n 2)Agregar Clientes \n 3)Ver empleados \n 4)Agregar Empleados \n 5)Modificar empleados \n 6)Ver productos \n 7)Agregar Productos \n 8)Realizar Compra \n 9)Ver detalle de las compras \n 10)Simulacion \n 11)Salir");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    c.VerClientes();

                }
                if (option == "2")
                {
                    Console.WriteLine("Inserte los datos del cliente: \n 1)Rut \n 2)Nombre \n 3)Apellido \n 4)Fecha de Nacimiento \n 5)Nacionalidad");
                    string rut = Console.ReadLine();
                    string nombre = Console.ReadLine();
                    string apellido = Console.ReadLine();
                    string fecha = Console.ReadLine();
                    string nacionalidad = Console.ReadLine();

                    Client client = new Client(rut, nombre, apellido, fecha, nacionalidad);
                    c.Agregarcliente(client);

                }
                if (option == "3")
                {
                    e.VerEmpleados();
                }

                if (option == "4")
                {
                    Console.WriteLine("Inserte los datos del empleado: \n 1)Rut \n 2)Nombre \n 3)Apellido \n 4)Fecha de Nacimiento \n 5)Nacionalidad \n 6)Trabajo \n 7)Salario \n 8)Horario");

                    string rut = Console.ReadLine();
                    string nombre = Console.ReadLine();
                    string apellido = Console.ReadLine();
                    string fecha = Console.ReadLine();
                    string nacionalidad = Console.ReadLine();
                    string trabajo = Console.ReadLine();
                    string salario = Console.ReadLine();
                    string horario = Console.ReadLine();
                    int sal = int.Parse(salario.ToString());

                    Employee employee = new Employee(trabajo, sal, horario, rut, nombre, apellido, fecha, nacionalidad);
                    e.Agregarempleado(employee);
                }

                if (option=="5")
                {
                    Console.WriteLine("Seleccione la opcion: \n 1)Cambiar puesto de trabajo \n 2)Cambiar sueldo \n 3)Cambiar horario");
                    string op = Console.ReadLine();
                    if (op=="1")
                    {
                        Console.WriteLine("Escriba el rut del empleado que quiere modificar: ");
                        string seleccionado = Console.ReadLine();
                        Console.WriteLine("Escriba nuevo puesto de trabajo: ");
                        string nuevotrabajo = Console.ReadLine();
                        e.Cambiartrabajo(nuevotrabajo, seleccionado);

                    }
                    if (op == "2")
                    {
                        Console.WriteLine("Escriba el rut del empleado que quiere modificar: ");
                        string seleccionado = Console.ReadLine();
                        Console.WriteLine("Escriba el nuevo sueldo: ");
                        string nuevosueldo = Console.ReadLine();
                        e.Cambiartrabajo(nuevosueldo, seleccionado);

                    }
                    if (op == "3")
                    {
                        Console.WriteLine("Escriba el rut del empleado que quiere modificar: ");
                        string seleccionado = Console.ReadLine();
                        Console.WriteLine("Escriba nuevo horario: ");
                        string nuevohorario = Console.ReadLine();
                        e.Cambiartrabajo(nuevohorario, seleccionado);

                    }



                }
                if (option == "6")
                {
                    p.VerProductos();
                }
                if (option == "7")
                {
                    Console.WriteLine("Ingrese los datos del producto: \n 1)Nombre del Producto \n 2)Precio \n 3)Stock \n 4)Marca \n 5)Codigo del Producto");
                    string nombre = Console.ReadLine();
                    string precio = Console.ReadLine();
                    string stock = Console.ReadLine();
                    string marca = Console.ReadLine();
                    string codigo = Console.ReadLine();
                    int price = int.Parse(precio.ToString());
                    int sto = int.Parse(stock.ToString());
                    int cod = int.Parse(codigo.ToString());

                    Product product = new Product(nombre, price, sto, marca, cod);
                    p.AgregarProducto(product);

                }
                if (option == "8")
                {
             
                    Console.WriteLine("Agregue sus datos para identificarse como cliente: \n 1)Rut \n 2)Nombre \n 3)Apellido \n 4)Fecha de Nacimiento \n 5)Nacionalidad");
                    string rut = Console.ReadLine();
                    string nombre = Console.ReadLine();
                    string apellido = Console.ReadLine();
                    string fecha = Console.ReadLine();
                    string nacionalidad = Console.ReadLine();
                    Client client1 =new Client(rut, nombre, apellido, fecha, nacionalidad);


                    Console.WriteLine("Inserte los datos del cajero: \n 1)Rut \n 2)Nombre \n 3)Apellido \n 4)Fecha de Nacimiento \n 5)Nacionalidad \n 6)Salario \n 7)Horario");

                    string ruti = Console.ReadLine();
                    string nombrei = Console.ReadLine();
                    string apellidoi = Console.ReadLine();
                    string fechai = Console.ReadLine();
                    string nacionalidadi = Console.ReadLine();
                    string salario = Console.ReadLine();
                    string horario = Console.ReadLine();
                    int sal = int.Parse(salario.ToString());
                    Employee employee1 = new Employee("cajero", sal, horario, ruti, nombrei, apellidoi, fechai, nacionalidadi);

                    Console.WriteLine("\n Cuantos productos desea comprar?: ");
                    string num = Console.ReadLine();
                    int numero = int.Parse(num.ToString());

                    for(int i = 0; i<numero;)
                    {
                        Console.WriteLine("Ingrese: \n 1)Nombre del producto \n 2)Marca del producto \n 3)Cantidad que comprara");
                        string nombreproducto = Console.ReadLine();
                        string marcaproducto = Console.ReadLine();
                        string n = Console.ReadLine();
                        int cantidadcomprar = int.Parse(n.ToString());
                        
                        
                        if (p.CarroCompra(nombreproducto, marcaproducto, cantidadcomprar) == false)
                        {
                            Console.WriteLine("vuelva a ingresar otro");
                        }
                        else
                        {
                            p.CambiarStock(cantidadcomprar, nombreproducto, marcaproducto);
                            i++;
                        }

                    }

                    Console.WriteLine("\n El stock actualizado es : ");
                    p.VerProductos();


                    Console.WriteLine("\n Su compra ha sido realizada: ");
                    p.VerCompra();

                   
                    r.RealizarCompra(p.Productoscomprados(),client1,employee1);

                    p.VaciarCarro();







                }
                if (option == "9")
                {
                    r.VerTodaslascompras();
                }
                if (option == "10")
                {
                    Console.WriteLine("Ha ingresado a la simulacion: ");
                    //Clientes random
                   // Client cli = new Client(a, b, d, e, f);
                   
                    
                }


                if (option == "11")
                {
                    break;
                }
                if (option != "1" && option != "2" && option != "3" && option != "4" && option != "5" && option != "6" && option != "7" && option != "8" && option != "9" && option != "10" && option != "11" )
                {
                    Console.WriteLine("Opcion no valida, vuelva a ingresarla");
                    
                }





            }
        }
    }
}

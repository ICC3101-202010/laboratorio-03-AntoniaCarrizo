using System;
using System.Collections.Generic;

namespace Laboratorio3AntoniaCarrizo
{
    public class Product
    {
        private List<Product> listproduct = new List<Product>();
        private List<Product> productoscomprados = new List<Product>();
        
        private string nameProduct;
        private int price;
        private int stock;
        private string brand;
        private int codigoproducto;
       
        //el codigo del producto sera unico para cada tipo de producto, así se podran diferenciar mejor
        public Product(string nameProduct,int price, int stock, string brand, int codigoproducto)
        { 
            this.nameProduct = nameProduct;
            this.price = price;
            this.stock = stock;
            this.brand = brand;
            this.codigoproducto = codigoproducto;
        }
        public Product()
        {

        }
        public string NameProduct()
        {
            return nameProduct;
        }
        public int Price()
        {
            return price;
        }
        public int Stock()
        {
            return stock;
        }
        public string Brand()
        {
            return brand;
        }
        public int Codigoproducto()
        {
            return codigoproducto;
        }
        public List<Product> Listproduct()
        {
            return listproduct;
        }
        public List<Product> Productoscomprados()
        {
            return productoscomprados;
        }


        public bool AgregarProducto(Product product)
        {
            for (int a = 1; a < listproduct.Count;)
            {
                if (listproduct[a].Codigoproducto() == product.Codigoproducto())
                {
                    Console.WriteLine("El producto ya estaba anteriormente agregado");
                    return false;
                }
                else
                {
                    a++;
                }

            }
            listproduct.Add(product);
            return true;

        }
        public void VerProductos()
        {
            int n = 1;
            for (int i = 0; i < listproduct.Count; i++)
            {
                Console.WriteLine(n + ") " + listproduct[i].Codigoproducto() + "-" + listproduct[i].NameProduct() + " - Marca: "+listproduct[i].Brand()+" - Stock: " + listproduct[i].Stock());
                n++;
            }
        }

        public bool CambiarStock(int cantidadcomprada, string nom, string mar)
        {
            for (int a = 0; a < listproduct.Count;)
            {
                if (listproduct[a].NameProduct() == nom && listproduct[a].Brand() == mar)
                {
                    string nombre= listproduct[a].NameProduct();
                    int precio = listproduct[a].Price();
                    int stock = listproduct[a].Stock()-cantidadcomprada;
                    string marca = listproduct[a].Brand();
                    int codigo = listproduct[a].Codigoproducto();
                   
                    listproduct.RemoveAt(a);
                    Product product = new Product(nombre,precio,stock,marca,codigo);
                    listproduct.Insert(a, product);
                    return true;
                }
                else
                {
                    a++;
                }

            }
            Console.WriteLine("El Producto no existe");
            return false;
        }

        public bool CarroCompra(string nombreproducto, string marcaproducto, int cantidadcomprar)
        {

            for (int i = 0; i < listproduct.Count;)
            {
                if (listproduct[i].NameProduct() == nombreproducto && listproduct[i].Brand() == marcaproducto)
                {
                    if (listproduct[i].Stock() < cantidadcomprar)
                    {
                        Console.WriteLine("no existe disponibilidad del producto");
                        return false;
                        
                    }
                    else
                    {
                        
                        Product product = new Product(nombreproducto, listproduct[i].Price(), cantidadcomprar, listproduct[i].Brand(), listproduct[i].Codigoproducto());
                        productoscomprados.Add(product);
                        return true;
                    }

                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine("El producto no existe");
            return false;



        }
        public void VerCompra()
        {
            int n = 1;
            for (int i = 0; i < productoscomprados.Count; i++)
            {
                Console.WriteLine(n + ") " + productoscomprados[i].NameProduct() + "-" + productoscomprados[i].Brand() + "- Cantidad: " + productoscomprados[i].Stock());
                n++;
            }
        }
    }
}

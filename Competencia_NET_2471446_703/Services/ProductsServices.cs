using Competencia_NET_2471446_703.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competencia_NET_2471446_703.Services
{
    public class ProductsServices
    {

        static List<Product> listProducts = new List<Product>();
        Product Product;
        public void navProduct()
        {
            Console.WriteLine("Productos\n");
            int opcion = 0;
            do
            {
                Console.WriteLine("\n1. Registrar\n2. Lstar\n3. Buscar\n4. Actualizar\n5. Eliminar \n 6.Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        RegisterProduct();
                        break;
                    case 2:
                        ListProducts();
                        break;
                    case 3:
                        SeacrhProduct();
                        break;
                    case 4:
                        //UpdateProduct();
                        break;
                    case 5:
                        RemoverProduct();
                        break;
                    case 6:
                        Console.WriteLine("Saliste de el sistema");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            } while (opcion != 6);

        }

        public int CodeSale()
        {
            return listProducts.Count() + 1;
        }



        public void RegisterProduct()
        {
            Console.WriteLine("Nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Cantidad");
            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor");
            int valor = int.Parse(Console.ReadLine());

            listProducts.Add(new Product(CodeSale(), nombre, cantidad, valor));
            Console.Clear();
        }



        public void ListProducts()
        {
            foreach (Product Producte in listProducts)
            {
                Console.Write(Producte);
            }
        }



        public void SeacrhProduct()
        {
            Console.WriteLine("Ingrese el id: ");
            int id = int.Parse(Console.ReadLine());
            int count = 0;
            foreach (var Products in listProducts)
            {
                if (Products.Id == id)
                {
                    count++;
                    Console.WriteLine(Products);
                    break;
                }
            }
            if (count != 1)
            {
                Console.WriteLine("Producte no encontrado");
            }

        }


        public void RemoverProduct()
        {
            Console.WriteLine("Ingrese el id: ");
            int id = int.Parse(Console.ReadLine());
            foreach (var Products in listProducts)
            {
                if (Products.Id == id)
                {
                    listProducts.Remove(Products);
                    Console.WriteLine("Producte eliminado exitosamente");
                    break;
                }
                else { Console.WriteLine("Producte no encontrado"); }
            }
        }
    }
}

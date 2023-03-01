using Competencia_NET_2471446_703.Models;
using Competencia_NET_2471446_703.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competencia_NET_2471446_703
{
    public class Program
    {
        static UsersServices usersServices = new UsersServices();
        static ClientsServices clientsServices = new ClientsServices();

        static void Main(string[] args)
        {
            usersServices.seeders();
            Console.WriteLine("Bienvenido\n");
            bool siExiste = false;
            do
            {
                Console.WriteLine("*************************\nUsuario");
                string email = Console.ReadLine();
                Console.WriteLine("Password");
                string password = Console.ReadLine();
                Console.WriteLine("*************************");

                if (!usersServices.login(email, password))
                {
                    Console.WriteLine("*************************\nOpp! Credenciales incorrectas");
                    Console.WriteLine("¿Desea crear una cuenta 1. SI / 2. NO");
                    int opcionRegistro = int.Parse(Console.ReadLine());
                    if (opcionRegistro == 1)
                    {
                        usersServices.RegisterUsers();
                    }
                    Console.WriteLine("*************************");
                }
                else
                {
                    siExiste = true;
                    int opcion = 0;
                    do
                    {
                        Console.WriteLine("Menu de opciones\n1. Clientes");
                        opcion = int.Parse(Console.ReadLine());
                        switch (opcion)
                        {
                            case 1:
                                clientsServices.navClient();
                                break;
                            default:
                                break;
                        }
                    } while (opcion != 6);
                }
            } while (!siExiste);
        }

    }
}


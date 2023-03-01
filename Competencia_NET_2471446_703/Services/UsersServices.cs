using Competencia_NET_2471446_703.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competencia_NET_2471446_703.Services
{
    public class UsersServices
    {

        public List<User> listUsers = new List<User>();
        User users;
        public void navUsers()
        {
            Console.WriteLine("Usuarios\n");
            int opcion = 0;
            do
            {
                Console.WriteLine("\n1. Registrar\n2. Lstar\n3. Buscar\n4. Actualizar\n5. Eliminar \n 6.Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        RegisterUsers();
                        break;
                    case 2:
                        ListUsers();
                        break;
                    case 3:
                        // SeacrhUsers();
                        break;
                    case 4:
                        //UpdateUsers();
                        break;
                    case 5:
                        //RemoverUsers();
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


        public void RegisterUsers()
        {
            Console.WriteLine("Aquí va el registro");
            Console.WriteLine("Documento");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Email");
            string email = Console.ReadLine();
            listUsers.Add(new User(id, nombre, "Demostracion", email, "Hola1234567"));
            Console.Clear();
        }



        public void ListUsers()
        {
            foreach (User user in listUsers)
            {
                Console.Write(user);
            }
        }



        public void SeacrhClient()
        {
            Console.WriteLine("Ingrese el id: ");
            int id = int.Parse(Console.ReadLine());
            int count = 0;
            foreach (var Users in listUsers)
            {
                if (Users.Id == id)
                {
                    count++;
                    Console.WriteLine(Users);
                    break;
                }
            }
            if (count != 1)
            {
                Console.WriteLine("Cliente no encontrado");
            }

        }


        public void UpdateClient()
        {

        }


        public void RemoverClient()
        {
            Console.WriteLine("Ingrese el id: ");
            int id = int.Parse(Console.ReadLine());
            foreach (var Users in listUsers)
            {
                if (Users.Id == id)
                {
                    listUsers.Remove(Users);
                    Console.WriteLine("Cliente eliminado exitosamente");
                    break;
                }
                else { Console.WriteLine("Cliente no encontrado"); }
            }
        }



        public void seeders()
        {
            listUsers.Add(new User(1051890890, "Manuela", "Hoyos", "manuela@gmail.com", "Manuela2023"));
        }







        /********************
         * Accesos
         ****************/

        public bool login(string email, string password)
        {
            foreach (var User in listUsers)
            {
                if (User.Email == email && User.Password == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competencia_NET_2471446_703.Services
{
    public class SalesServices
    {

        public void navUsers()
        {
            Console.WriteLine("Usuarios\n");
            int opcion = 0;
            do
            {
                Console.WriteLine("\n1. Registrar\n2. Lstar\n3. Buscar\n4.Cancelar \n 6.Salir");
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


    }
}

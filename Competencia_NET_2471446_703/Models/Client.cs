using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competencia_NET_2471446_703.Models
{
    public class Client : BaseModel
    {
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public string City { get; set; }



        public Client() { }

        public Client(int id, string name, string lastname, string phone, string location, string city)
        {
            Id = id;
            Name = name;
            LastName = lastname;
            PhoneNumber = phone;
            Location = location;
            City = city;
        }


        public override string ToString()
        {
            return string.Format($"Nombre: {Name}\n" +
                $"Apellidos: {LastName}\n" +
                $"City: {City}\n" +
                $"Dirección: {Location}\n" +
                $"Telefono: {PhoneNumber}\n");
        }


    }
}

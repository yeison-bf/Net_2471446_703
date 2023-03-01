using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competencia_NET_2471446_703.Models
{
    public class User : BaseModel
    {
        public string Email { get; set; }
        public string Password { get; set; }


        public User() { }

        public User(int id, string name, string lastname, string email, string password)
        {
            Id = id;
            Name = name;
            LastName = lastname;
            Email = email;
            Password = password;
        }


        public override string ToString()
        {
            return string.Format($"Nombre: {Name}\n" +
                $"Apellidos: {LastName}\n" +
                $"City: {Email}\n");
        }

    }
}

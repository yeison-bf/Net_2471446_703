using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competencia_NET_2471446_703.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int Client_Id { get; set; }
        public int Product_Id { get; set; }
        public int Count_sale { get; set; }
        public int Value_Unique { get; set; }
        public int Value_Total { get; set; }
        public int User_Id { get; set; }
        public int Statuse { get; set; }




        public Sale()
        {

        }

    }
}

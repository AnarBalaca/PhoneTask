using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NokiaSimulator.Models
{
    public class Contact
    {
        private readonly int _Id = 0;
        
        public int Id { get => +_Id;  }
        public string? FullName { get; set; }
        public int Number { get; set; }

        public Contact(string Name , int Num)
        {
            FullName = Name;
            Number = Num;

        }





    }
}

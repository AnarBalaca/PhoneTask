using NokiaSimulator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NokiaSimulator.Models
{
    public class Phone
    {
        public int Number { get; set; }
        public Provider Providers { get; set; }
        public decimal Balance { get; set; }
        public ICollection<Contact>? ContactList { get; set; }





        public void AddContact(string contactName , int contactNum)
        {
            Contact contact = new Contact(contactName , contactNum);


            ContactList.Add(contact);

        }


        public void GetContactList()
        {
            Exception exception = new Exception("NULL SIUUUUU!");

            if (ContactList is null)
            {
                throw exception;
            }
            else
            {
                foreach (var contact in ContactList)
                {
                    Console.WriteLine(contact);

                }
            }
        }



        public void AddBalance(decimal balance)
        {
            Balance += balance;
            Console.WriteLine(Balance);
        }


        public void ChooseProvider()
        {
            Console.WriteLine($"1:{Provider.Nar}:\n" +
                              $"2:{Provider.Azercell} \n" +
                              $"3:{Provider.Bakcell}");
            
            

        }

        public void PhoneCall()
        {
            

        }








    }
}

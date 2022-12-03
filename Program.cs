using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact()
            {
                FirstName = "Sayed",
                LastName = "Faizan",
                Address = "Jammu",
                City = "Jammu",
                State = "Jammu and Kashmir",
                Zip = 185212,
                PhoneNumber = 962278,
                Email = "sayedfaizanqadri@gmail.com",
            };
            Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
        }
    }
}
using System;
using contacts;
using System.Collections.Generic;
namespace phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is phonebook World!");
           
             Dictionary<string, double> contact = new Dictionary<string, double>();
             Contacts c = new Contacts();
             Console.WriteLine("enter your option 1.add\n 2.delete 3.edit 4.search conatct 5.Get all contact");
            int  selection = int.Parse(Console.ReadLine());
             switch (selection)
             {
             case 1: c.AddContact(contact);
                     break;
             case 2: c.DeleteContact(contact);
                       break;
             case 3: c.EditContact(contact);
                       break;
             case 5: c.getContacts(contact);
                       break;
             case 4: c.searchContact(contact);
                       break;

             }         
       }
    }   

    
}

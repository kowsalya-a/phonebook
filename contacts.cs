using System;
using System.Collections.Generic;
using phonebook;
namespace contacts
{
    class Contacts
    {
        
        public double phNo {get;set;}
        public string contactName {get;set;}
       
     public  void AddContact( Dictionary<string, double> contact)
        {         
          Console.WriteLine("enter the name") ;
          contactName = Console.ReadLine();
          Console.WriteLine("enter the number");
          phNo = Convert.ToDouble(Console.ReadLine());
           contact.Add(contactName,phNo);
           Console.WriteLine("contact is added");

        }

    public   void DeleteContact( Dictionary<string, double> contact)
       {
          Console.WriteLine("enter the name to be deleted") ;
          contactName = Console.ReadLine();          
          contact.Remove(contactName);
       }

     public  void EditContact(Dictionary<string, double> contact)
       {
            Console.WriteLine("enter the name whose number to be edited ") ;
            contactName = Console.ReadLine();
            contact.TryGetValue(contactName,out double Value);
            Console.WriteLine("enter the new number ") ;
            double   number=Convert.ToDouble(Console.ReadLine());
            contact[contactName] = number;
       }
       public void searchContact(Dictionary<string, double> contact)
        {
            Console.WriteLine("enter the name to search ") ;
            string name = Console.ReadLine();
            contact.TryGetValue(name,out double Value);
             Console.WriteLine("the contact No of {0} is {1}",name,Value) ;

       }
    
     public void getContacts(Dictionary<string, double> contact)
     {
       foreach (KeyValuePair<string,double> item in contact)
      {
       Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
      }

     }

    }
}
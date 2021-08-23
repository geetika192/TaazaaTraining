using System.Collections;
using System.Collections.Generic;
using Practice.Model;
using System;
namespace Practice.Collections
{
    public class ContactLists
    {
           List<Contact> obj ; //not yet memory is allocated   //Instance variable
           public ContactLists()
           {
              obj=new List<Contact>();   //constructor
           }
           public List<Contact> CreateContact()   //Member Function
           {
               obj.Add(new Contact{
                    contactId=101,
                    ContactName="Geetika",
                    ContactPhoneNumber=9198
               });
               obj.Add(new Contact{
                    contactId=102,
                    ContactName="Geetu",
                    ContactPhoneNumber=1234
               });
               obj.Add(new Contact{
                    contactId=103,
                    ContactName="Divya",
                    ContactPhoneNumber=8765
               });
               obj.Add(new Contact{
                    contactId=104,
                    ContactName="Deepti",
                    ContactPhoneNumber=5678
               });
               return obj;
           }

          public List<Contact> Modify()
          {
            obj.Insert(2,new Contact(){contactId=105,ContactName="Bharti",ContactPhoneNumber=66555});
            //System.Console.WriteLine("List is Modified");
            return obj;

          }
          public void Search()
          {
            Contact contact =obj.Find(contact=>contact.contactId==121);
            System.Console.WriteLine("found");
          }
          public List<Contact> deleteContact()
        {
            int target =1;
            obj.RemoveAt(target);
            return obj;
        }
        public List<Contact> updateContact()
       {
         var temp=obj[2];
        temp.ContactName="Jerry";
         return obj;
       }



          
        }
 }

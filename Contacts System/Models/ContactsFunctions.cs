using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contacts_System.Models
{
    public class ContactsFunctions
    {
        ContactsDbContext contactsDbContext = new Models.ContactsDbContext();
        public List<Contacts> GetContacts()
        {
           
          return  contactsDbContext.contacts.ToList();
        }
        public void AddContact(Contacts c )
        {
            contactsDbContext.contacts.Add(c);
            contactsDbContext.SaveChanges();
        }

     public void Update(Contacts c)
        {
            Contacts cc = contactsDbContext.contacts.FirstOrDefault(s => s.id == c.id);
            cc.FirstName = c.FirstName;
            cc.LastName = c.LastName;
            cc.Phone = c.Phone;
            cc.Email = c.Email;
            cc.Address = c.Address;
            contactsDbContext.SaveChanges();
        }
        public void Delete(Contacts c)
        {
            Contacts cc = contactsDbContext.contacts.FirstOrDefault(s => s.id == c.id);
            contactsDbContext.contacts.Remove(cc);
            contactsDbContext.SaveChanges();
        }
      
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Contacts_System.Models
{
    public class ContactsDbContext:DbContext
    {
        public ContactsDbContext() : base("name=ContactsDbContaxt")
        { }

        public DbSet<Contacts> contacts { get; set; }


    }
}
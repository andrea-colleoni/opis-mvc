using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Giorno1Oggetti
{
    public class Giorno1Context : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }
}

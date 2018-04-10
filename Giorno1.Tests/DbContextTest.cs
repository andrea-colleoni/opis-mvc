using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Giorno1Oggetti;

namespace Giorno1.Tests
{
    [TestClass]
    public class DbContextTest
    {
        [TestMethod]
        public void TestDBContext()
        {
            using (var ctx = new Giorno1Context())
            {
                ctx.Companies.Add(new Company
                {
                    Nome = "Opis",
                    Email = "opis@opis.it",
                    NumeroDipendenti = 100,
                    DataCostituzione = null
                });

                ctx.SaveChanges();
            }
        }
    }
}

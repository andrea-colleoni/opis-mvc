using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Migrazione;

namespace Giorno1.Tests
{
    [TestClass]
    public class MigrazioneTest
    {
        [TestMethod]
        public void TestVista()
        {
            Model db = new Model();

            foreach(var item in db.vw_contatti_con_company)
            {
                Console.Out.WriteLine(item.NomeContatto);
            }

            var contact = db.vw_contatti_con_company.Find("Esselunga");
            Console.Out.WriteLine("******" + contact.NomeContatto);
        }
    }
}

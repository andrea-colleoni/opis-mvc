using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Giorno1Oggetti;

namespace Giorno1.Tests
{
    [TestClass]
    public class TestOggettiNuovi
    {
        [TestMethod]
        public void TestMethod1()
        {
            var db = new Giorno1Context();

            var c = db.Contacts.Find(2);

            var car = db.Cars.Find("123456");
            var car2 = new Automobile();
            car2.Telaio = "888";
            car2.Targa = "XX143YY";

            db.Cars.Add(car2);

            var r = new Reservation();
            r.DataViaggio = DateTime.Now;
            r.auto = car;
            r.contatto = c;

            db.Reservations.Add(r);

            db.SaveChanges();

        }

        [TestMethod]
        public void TestMethod2()
        {
            var db = new Giorno1Context();
            var c = db.Contacts.Find(1);
            var car = db.Cars.Find("123456");

            c.viaggi.Add(new Reservation
            {
                //contatto = c,
                auto = car,
                DataViaggio = DateTime.Now
            });

            db.SaveChanges();
        }
    }
}

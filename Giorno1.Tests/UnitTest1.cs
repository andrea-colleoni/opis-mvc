using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Giorno1Oggetti;

namespace Giorno1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreaSchemaEreditarieta()
        {
            EreditarietaContext db = new EreditarietaContext();

            var i = new SubItem1
            {
                propItem = "test",
                subProp1 = "sp1"
            };

            db.Item.Add(i);

            db.Child1.Add(new Child1
            {
                item = i,
                child1Prop = 6
            });

            db.SaveChanges();
        }
    }
}

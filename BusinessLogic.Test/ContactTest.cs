using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test
{
    [TestClass]
    public class ContactTest
    {
        [TestMethod]
        public void NewContactTest()
        {
            var contact = new Contact();
            Assert.IsNotNull(contact);
        }
    }
}

using Tyuiu.Tidzhanin.Sprint0.Task2.V0.Lib;

namespace Tyuiu.Tidzhanin.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
 
        public void CheckGetMessageValid()
        {
            var name = "Тиджани";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Тиджани", res);
        }
    }
}

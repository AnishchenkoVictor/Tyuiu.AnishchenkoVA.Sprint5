namespace Tyuiu.AnishchenkoVA.Sprint5.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\mifis\source\repos\Tyuiu.AnishchenkoVA.Sprint5\DataSprint5\InPutDataFileTask4V4";
            FileInfo FI = new FileInfo(path);
            bool fe = FI.Exists;
            bool z = true;
            Assert.AreEqual(z, fe);
        }
    }
}
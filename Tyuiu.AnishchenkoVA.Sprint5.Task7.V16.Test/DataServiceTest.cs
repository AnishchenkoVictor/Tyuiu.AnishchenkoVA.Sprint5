namespace Tyuiu.AnishchenkoVA.Sprint5.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\mifis\source\repos\Tyuiu.AnishchenkoVA.Sprint5\DataSprint5\InPutDataFileTask7V16.txt";
            FileInfo FI = new FileInfo(path);
            bool fx = FI.Exists;
            bool z = true;
            Assert.AreEqual(z, fx);
        }
    }
}
namespace Tyuiu.AnishchenkoVA.Sprint5.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\mifis\source\repos\Tyuiu.AnishchenkoVA.Sprint5\DataSprint5\InPutDataFileTask5V4.txt";
            FileInfo FI = new FileInfo(path);
            bool fe = FI.Exists;
            bool z = true;
            Assert.AreEqual(z, fe);
        }
    }
}
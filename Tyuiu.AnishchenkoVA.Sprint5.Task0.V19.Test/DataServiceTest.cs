namespace Tyuiu.AnishchenkoVA.Sprint5.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\mifis\AppData\Local\Temp\tmptdb3s3.tmp";
            FileInfo FI = new FileInfo(path);
            bool fe = FI.Exists;
            bool z = true;
            Assert.AreEqual(z, fe);
        }
    }
}
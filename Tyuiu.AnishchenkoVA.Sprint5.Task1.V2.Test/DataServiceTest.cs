namespace Tyuiu.AnishchenkoVA.Sprint5.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\mifis\AppData\Local\Temp\tmpbx2bge.tmp";
            FileInfo FI = new FileInfo(path);
            bool fe = FI.Exists;
            bool z = true;
            Assert.AreEqual(z, fe);
        }
    }
}
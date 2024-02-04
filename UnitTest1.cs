using System.Threading.Tasks;
using Xunit.Sdk;

namespace BillingEngineEnhancement_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testcase()
        {
        //C: \Users\admin\Desktop\Problem - Tark\BillingEngineEnhancement\BillingEngine.csproj
            string directory1 = "../../../../BillingEngineEnhancement/TestCases/Output";
            string directory2 = "../../../../BillingEngineEnhancement/Output/Testcase";
            string[] actualFiles = Directory.GetFiles(directory1);
            string[] expectedFiles = Directory.GetFiles(directory2);
            if (actualFiles.Count() != expectedFiles.Count()) Assert.Fail("Number of files not match");

            for(int i = 0;i < actualFiles.Length; i++)
            {
                string[] actual = File.ReadAllLines(actualFiles[i]);
                string[] expected = File.ReadAllLines(expectedFiles[i]);
                if (actual.Length != expected.Length) Assert.Fail("Number of lines not match " + Path.GetFileNameWithoutExtension(actualFiles[i]));
                for(int j = 0;j < expected.Length; j++)
                {
                    if (!actual[j].Equals(expected[j])) Console.WriteLine("WA,"  + actual[j] + "," + expected[j] + ",in file" + Path.GetFileNameWithoutExtension(actualFiles[i]));
                }
            }
        }
    }
}
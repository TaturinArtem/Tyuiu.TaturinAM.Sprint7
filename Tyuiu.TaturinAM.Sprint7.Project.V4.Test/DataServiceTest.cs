using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TaturinAM.Sprint7.Project.V4.Lib;
using System.IO;
namespace Tyuiu.TaturinAM.Sprint7.Project.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\BookBase.csv";
            string[,] res = ds.GetBase(pathSaveFile);
            string[,] wait = { { "value1", "value2" }, { "value3", "value4" } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}

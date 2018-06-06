using Microsoft.VisualStudio.TestTools.UnitTesting;
using Counting_Inversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Inversion.Tests
{
    [TestClass()]
    public class FileServiceTests
    {
        [TestMethod()]
        public void ReadFileTest()
        {
            //arrange
            int array2 = 14108;
            var list = FileService.ReadFile();
            //act
            //assert
            Assert.AreEqual(array2, list[1]);
        }
    }
}
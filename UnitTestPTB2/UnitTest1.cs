using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PTB2;

namespace UnitTestPTB2
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void Test_PTB2_VoNghiem()
        {
            //Arrang 
           PhuongTrinh2 ptb2 = new PhuongTrinh2();
            //Act
           
            float b=0;
            float c=0;
            bool value = ptb2.PTVoNghiem(b,c);
            //Assert
            Assert.IsTrue(value);
        }
    }
}

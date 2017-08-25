using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IbanHelper;

namespace IbanHelper.Test
{
    [TestClass]
    public class UnitTest1
    {
        #region not match regex
        [TestMethod]
        public void TestInvalidRegex1()
        {
            var expectedResult = false;
            string iban = "IX062960000000100324200001";//IX
            var validationResult = IbanUtil.ValidateIBAN(iban);
            Assert.AreEqual(expectedResult, validationResult);
        }
        [TestMethod]
        public void TestInvalidRegex2()
        {
            var expectedResult = false;
            string iban = "IR0629600000001003242000013";//27 char
            var validationResult = IbanUtil.ValidateIBAN(iban);
            Assert.AreEqual(expectedResult, validationResult);
        }
        [TestMethod]
        public void TestInvalidRegex3()
        {
            var expectedResult = false;
            string iban = "IRR62960000000100324200001";//IRR
            var validationResult = IbanUtil.ValidateIBAN(iban);
            Assert.AreEqual(expectedResult, validationResult);
        }
        [TestMethod]
        public void TestInvalidRegex4()
        {
            var expectedResult = false;
            string iban = "IR6296000000010032420000";//25 char
            var validationResult = IbanUtil.ValidateIBAN(iban);
            Assert.AreEqual(expectedResult, validationResult);
        }
        #endregion

        #region mellat
        [TestMethod]
        public void TestTrueMellat1()
        {
            var expectedResult = true;
            string iban = "IR062960000000100324200001";
            var validationResult = IbanUtil.ValidateIBAN(iban);
            Assert.AreEqual(expectedResult, validationResult);
        }
        [TestMethod]
        public void TestFalseMellat1()
        {
            var expectedResult = false;
            string iban = "IR062960000000100324200002";
            var validationResult = IbanUtil.ValidateIBAN(iban);
            Assert.AreEqual(expectedResult, validationResult);
        }
        [TestMethod]
        public void TestTrueMellat2()
        {
            var expectedResult = true;
            string iban = "IR500120000000000266719902";
            var validationResult = IbanUtil.ValidateIBAN(iban);
            Assert.AreEqual(expectedResult, validationResult);
        }
       
       [TestMethod]
        public void TestFalseMellat2()
        {
            var expectedResult = false;
            string iban = "IR500120000000000266719903";
            var validationResult = IbanUtil.ValidateIBAN(iban);
            Assert.AreEqual(expectedResult, validationResult);
        }
        #endregion

        #region melli
        [TestMethod]
        public void TestTrueMelli1()
        {
            var expectedResult = true;
            string iban = " IR380170000000104183555002";
            var validationResult = IbanUtil.ValidateIBAN(iban);
            Assert.AreEqual(expectedResult, validationResult);
        }
        [TestMethod]
        public void TestFalseMelli1()
        {
            var expectedResult = false;
            string iban = " IR380170000000104183555004";
            var validationResult = IbanUtil.ValidateIBAN(iban);
            Assert.AreEqual(expectedResult, validationResult);
        }
        #endregion

        #region saderat
        [TestMethod]
        public void TestTrueSaderat1()
        {
            var expectedResult = true;
            string iban = " IR920190000000110017470004";
            var validationResult = IbanUtil.ValidateIBAN(iban);
            Assert.AreEqual(expectedResult, validationResult);
        }
        [TestMethod]
        public void TestFalseSaderat1()
        {
            var expectedResult = false;
            string iban = " IR920190000000110017470008";
            var validationResult = IbanUtil.ValidateIBAN(iban);
            Assert.AreEqual(expectedResult, validationResult);
        }
        #endregion

        #region parsian
        [TestMethod]
        public void TestTrueParsian()
        {
            var expectedResult = true;
            string iban = "IR062960000000100324200001";
            var validationResult = IbanUtil.ValidateIBAN(iban);
            Assert.AreEqual(expectedResult, validationResult);
        }
        [TestMethod]
        public void TestFalseParsian()
        {
            var expectedResult = false;
            string iban = "IR062760000000100324200001";
            var validationResult = IbanUtil.ValidateIBAN(iban);
            Assert.AreEqual(expectedResult, validationResult);
        }
        #endregion

        #region shahr
        [TestMethod]
        public void TestTrueShahr()
        {
            var expectedResult = true;
            string iban = "IR390610000000100801920157";
            var validationResult = IbanUtil.ValidateIBAN(iban);
            Assert.AreEqual(expectedResult, validationResult);
        }
        [TestMethod]
        public void TestFalseShahr()
        {
            var expectedResult = false;
            string iban = "IR390610000000100801920158";
            var validationResult = IbanUtil.ValidateIBAN(iban);
            Assert.AreEqual(expectedResult, validationResult);
        }

        #endregion
    }
}

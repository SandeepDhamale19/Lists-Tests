using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAutomation.Framework.Helpers.Strings;

namespace TestLists
{
    [TestClass]
    public class ListsTests
    {
        #region sequence

        //Pass
        [TestMethod]
        public void TestSequence_SequenceTrue_ExactMatchTrue_IgnoreCaseTrue()
        {
            List<string> listActualValues = new List<string> {"abc", "def", "pqr", "uvw", "xyz" };
            string listExpectedValues = "abc;def;pqr;uvw;xyz";
            bool areEqual = ListExtentions.VerifyListValues(listActualValues, listExpectedValues, false, true, false, false);
            Assert.AreEqual(true, areEqual);
        }

        //Fail
        [TestMethod]
        public void TestSequence_SequenceFalse_ExactMatchTrue_IgnoreCaseTrue()
        {
            List<string> listActualValues = new List<string> { "abc", "def", "pqr", "uvw", "xyz" };
            string listExpectedValues = "abc;pqr;uvw;xyz;def";
            bool areEqual = ListExtentions.VerifyListValues(listActualValues, listExpectedValues, false, true, false, false);
            Assert.AreEqual(true, areEqual);
        }

        #endregion

        #region IgnoreCase

        //Pass
        [TestMethod]
        public void TestIgnoreCase_SequenceTrue_ExactMatchTrue_IgnoreCaseTrue()
        {
            List<string> listActualValues = new List<string> { "abc", "def", "pqr", "UVW", "xyz" };
            string listExpectedValues = "abc;def;pqr;uvw;xyz";
            bool areEqual = ListExtentions.VerifyListValues(listActualValues, listExpectedValues, false, true, false, true);
            Assert.AreEqual(true, areEqual);
        }

        //Fail
        [TestMethod]
        public void TestIgnoreCase_SequenceTrue_ExactMatchTrue_IgnoreCaseFalse()
        {
            List<string> listActualValues = new List<string> { "abc", "def", "pqr", "UVW", "xyz" };
            string listExpectedValues = "abc;def;pqr;uvw;xyz";
            bool areEqual = ListExtentions.VerifyListValues(listActualValues, listExpectedValues, false, true, false, false);
            Assert.AreEqual(true, areEqual);
        }

        #endregion

        #region Exactmatch

        //Pass
        [TestMethod]
        public void TestExactmatch_SequenceTrue_ExactMatchTrue_IgnoreCaseTrue()
        {
            List<string> listActualValues = new List<string> { "abc", "def", "pqr", "uvw", "xyz" };
            string listExpectedValues = "abc;def;pqr;uvw;xyz";
            bool areEqual = ListExtentions.VerifyListValues(listActualValues, listExpectedValues, false, true, false, true);
            Assert.AreEqual(true, areEqual);
        }

        //Fail
        [TestMethod]
        public void TestExactmatch_SequenceTrue_ExactMatchFalse_IgnoreCaseTrue()
        {
            List<string> listActualValues = new List<string> { "abc", "defg", "pqr", "uvw", "xyz" };
            string listExpectedValues = "abc;def;pqr;uvw;xyz";
            bool areEqual = ListExtentions.VerifyListValues(listActualValues, listExpectedValues, false, true, false, false);
            Assert.AreEqual(true, areEqual);
        }

        #endregion

        #region SingleData

        //Pass
        [TestMethod]
        public void TestIsSingleData_SequenceTrue_ExactMatchTrue_IgnoreCaseTrue()
        {
            List<string> listActualValues = new List<string> { "abc", "abc", "abc", "abc", "abc" };
            string listExpectedValues = "abc";
            bool areEqual = ListExtentions.VerifyListValues(listActualValues, listExpectedValues, true, true, false, true);
            Assert.AreEqual(true, areEqual);
        }

        //Fail
        [TestMethod]
        public void TestIsSingleData_SequenceTrue_ExactMatchFalse_IgnoreCaseTrue()
        {
            List<string> listActualValues = new List<string> { "abc", "abc", "pqr", "abc", "abc" };
            string listExpectedValues = "abc";
            bool areEqual = ListExtentions.VerifyListValues(listActualValues, listExpectedValues, true, true, false, false);
            Assert.AreEqual(true, areEqual);
        }

        #endregion
        
    }
}

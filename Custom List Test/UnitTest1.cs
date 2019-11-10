using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_List_Project;

namespace Custom_List_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 12;
            int actual;

            // act
            testList.Add(12);

            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToList_CountIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(234);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);

            // unit test for adding multiple items to check position of last item
            // unit test for adding multiple items to check Count property
            // unit test for adding number of items beyond 'Capacity' but it still adds
        }
        [TestMethod]
        public void Add_5ItemsToList()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 5;
            int actual;

            // act
            testList.Add(67);
            testList.Add(67);
            testList.Add(67);
            testList.Add(67);
            testList.Add(67);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_4ItemsToList()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            // act
            testList.Add(67);
            testList.Add(67);
            testList.Add(67);
            testList.Add(67);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_FromList()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 0;
            int actual;

            // act
            testList.Add(234);
            testList.Remove(234);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);

            // unit test for adding multiple items to check position of last item
            // unit test for adding multiple items to check Count property
            // unit test for adding number of items beyond 'Capacity' but it still adds
        }
        [TestMethod]
        public void Remove_FromListAgain()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            // act
            testList.Add(234);
            testList.Add(234);
            testList.Add(234);
            testList.Remove(234);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);

            // unit test for adding multiple items to check position of last item
            // unit test for adding multiple items to check Count property
            // unit test for adding number of items beyond 'Capacity' but it still adds
        }
        [TestMethod]
        public void Remove_Shift()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 334;
            int actual;

            // act
            testList.Add(234);
            testList.Add(334);
            testList.Add(236);
            testList.Remove(234);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);

            // unit test for adding multiple items to check position of last item
            // unit test for adding multiple items to check Count property
            // unit test for adding number of items beyond 'Capacity' but it still adds
        }
        [TestMethod]
        public void Remove_ShiftMiddleCheck()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 240;
            int actual;

            // act
            testList.Add(234);
            testList.Add(236);
            testList.Add(238);
            testList.Add(240);
            testList.Remove(238);
            actual = testList[2];

            // assert
            Assert.AreEqual(expected, actual);

            // unit test for adding multiple items to check position of last item
            // unit test for adding multiple items to check Count property
            // unit test for adding number of items beyond 'Capacity' but it still adds
        }
        [TestMethod]
        public void TestOneToString()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            string expected = "1234";
            string actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            actual = testList.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestTwoToString()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            string expected = "4321";
            string actual;

            // act
            testList.Add(4);
            testList.Add(3);
            testList.Add(2);
            testList.Add(1);
            actual = testList.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadOperatorAdd()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);
            testList3 = testList1 + testList2;
            actual = testList3[0];
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadOperatorAddCustomeList1and2()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();
            int expected = 2;
            int actual;

            // act
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);
            testList3 = testList1 + testList2;
            actual = testList3[1];
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadOperatorAddCustomeCheckIndex2()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();
            int expected = 3;
            int actual;

            // act
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);
            testList3 = testList1 + testList2;
            actual = testList3[2];
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadOperatorRemove()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();
            int expected = 2;
            int actual ;

            // act
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList1.Add(4);
            testList2.Add(1);
            testList2.Add(6);
            testList2.Add(3);
            testList2.Add(4);
            testList3 = testList1 - testList2;
            actual = testList3[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadOperatorRemoveDupplicates()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();
            int expected = 4;
            int actual;

            // act
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList1.Add(4);
            testList2.Add(1);
            testList2.Add(2);
            testList2.Add(4);
            testList2.Add(6);
            testList3 = testList1 - testList2;
            actual = testList3[1];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadOperatorRemoveDupplicatesAgain()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();
            int expected = 4;
            int actual;

            // act
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList1.Add(4);
            testList2.Add(1);
            testList2.Add(2);
            testList2.Add(3);
            testList2.Add(6);
            testList3 = testList1 - testList2;
            actual = testList3[1];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipFunction_ZipsTwoCustomListsTogether()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 1;
            int actual;
            // act
            // act
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);
            testList2.Add(2);
            testList2.Add(4);
            testList2.Add(6);
            newList = testList1.Zip(testList2);
            actual = newList[0];
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipFunction_ZipsTwoCustomListsTogetherTwo()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 4;
            int actual;
            // act
            
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);
            newList = testList1.Zip(testList2);
            actual = newList[1];
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipFunction_ZipsTwoCustomListsTogetherThree()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 7;
            int actual;
            // act

            testList1.Add(6);
            testList1.Add(7);
            testList1.Add(8);
            testList2.Add(9);
            testList2.Add(10);
            testList2.Add(11);
            newList = testList1.Zip(testList2);
            actual = newList[2];
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}

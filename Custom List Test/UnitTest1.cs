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
        public void IntArrary_AddOneToAllIndex()
        {
            // arrange
            TestingClass thing = new TestingClass();
            int[] values = { 1, 2, 3, 4 };
            int[] expected = { 2, 3, 4, 5 };
            int[] actual;

            // act
            actual = thing.AddOneToArray(values);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IntArray_CallingMethodTwice()
        {
            // arrange
            TestingClass thing = new TestingClass();
            int[] values = {1, 2, 3, 4 };
            int[] values2;
            int[] expected = {3, 4, 5, 6 };
            int[] actual;

            // act
            values2 = thing.AddOneToArray(values);
            actual = thing.AddOneToArray(values2);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}

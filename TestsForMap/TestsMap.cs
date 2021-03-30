using NUnit.Framework;
using Array_Csharp_1laba;
using System.Collections.Generic;
using System;

namespace TestsForMap
{
    public class TestsMap
    {
        private Map<char, int> map;

        [SetUp]
        public void Setup()
        {
            map = new Map<char, int>();
        }

        [Test]
        public void InsertTest_ExistingKey_Exception()
        {
            map.Insert('a', 2);

            try
            {
                map.Insert('a', 10);

                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("An element with this key already exists", e.Message);
            }
        }

        [Test]
        public void InsertTest_InsertElement_CorrectInsert()
        {
            map.Insert('a', 1);

            int actual = map.Find('a').Data;

            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RemoveTest_RemoveNonexistentElement_Exception()
        {
            try
            {
                map.Insert('b', 5);
                map.Remove('r');

                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Item not found!", e.Message);
            }

        }

        [Test]
        public void RemoveTest_InsertElementAndRemove_CorrectRemove()
        {
            map.Insert('a', 1);
            map.Remove('a');

            Node<char, int> actual = map.Root;

            Node<char, int> expected = null;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindTest_TwoElement_CorrectFind()
        {
            map.Insert('b', 1);
            map.Insert('a', 7);

            Node<char, int> actual = map.Find('a');

            Assert.AreEqual(7, actual.Data);

        }

        [Test]
        public void FindTest_EmptyTree_Exception()
        {
            try
            {
                map.Find('b');

                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Array is empty!", e.Message);
            }

        }

        [Test]
        public void ClearTest_ClearTree_CorrectClear()
        {
            map.Insert('b', 1);
            map.Insert('a', 7);

            map.Clear();

            Assert.AreEqual(null, map.Root);

        }


        [Test]
        public void ClearTest_ClearEmptyTree_CorrectClear()
        {
            map.Clear();

            Assert.AreEqual(null, map.Root);

        }

        [Test]
        public void GetKeysIntTest_InsertThreeItems_GetThreeKeys()
        {
            map.Insert('3', 155);

            map.Insert('4', 423);

            map.Insert('5', 777);

            var actualKeys = map.GetKeys();

            var expectedKeys = new List<char> { '3', '4', '5' };

            Assert.IsTrue(AreEqualList(expectedKeys, actualKeys));
        }

        [Test]
        public void GetKeysIntTest_EmptyTree_NullResult()
        {

            var actualKeys = map.GetKeys();

            var expectedKeys = new List<char>();

            Assert.IsTrue(AreEqualList(expectedKeys, actualKeys));
        }


        [Test]
        public void GetValuesIntTest_InsertThreeItems_GetThreeValues()
        {
            map.Insert('3', 155);

            map.Insert('4', 423);

            map.Insert('5', 777);

            var actualKeys = map.GetValues();

            var expectedKeys = new List<int> { 155, 423, 777 };

            Assert.IsTrue(AreEqualList(expectedKeys, actualKeys));
        }

        [Test]
        public void GetValuesIntTest_EmptyTree_NullResult()
        {

            var actualValues = map.GetValues();

            var expectedValues = new List<int>();

            Assert.IsTrue(AreEqualList(expectedValues, actualValues));
        }

        [Test]
        public void PrintTest_EmptyMap_EmptyOutput()
        {

            string actual = PrintToString(map.GetKeys(), map.GetValues());

            string expected = "";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PrintTest_InsertElement_CorrectOutput()
        {
            map.Insert('g', 8);

            string actual = PrintToString(map.GetKeys(), map.GetValues());

            string expected = "g - 8";

            Assert.AreEqual(expected, actual);
        }


        private bool AreEqualList(List<char> list1, List<char> list2)
        {
            if (list1.Count != list2.Count)
            {
                return false;
            }

            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] != list2[i])
                {
                    return false;
                }
            }

            return true;
        }

        private bool AreEqualList(List<int> list1, List<int> list2)
        {
            if (list1.Count != list2.Count)
            {
                return false;
            }

            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] != list2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public string PrintToString(List<char> keys, List<int> values)
        {

            string output = "";

            if (keys == null)
            {
                return output;
            }
            for (int i = 0; i < keys.Count; i++)
            {
                output += $"{keys[i]} - {values[i]}";

            }

            return output;
        }

    }
}
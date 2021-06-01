using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _1744_CanYouEatYourFavoriteCandyOnYourFavoriteDayTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            int[] candiesCount = new int[] { 7, 4, 5, 3, 8 };
            int[][] queries = new int[][]{
                new int[] { 0, 2, 2 },
                new int[] { 4, 2, 4 },
                new int[] { 2, 13, 1000000000 }
            };
            _1744_CanYouEatYourFavoriteCandyOnYourFavoriteDay canYouEatYourFavoriteCandyOnYourFavoriteDay = new _1744_CanYouEatYourFavoriteCandyOnYourFavoriteDay();
            bool[] result = canYouEatYourFavoriteCandyOnYourFavoriteDay.CanEat(candiesCount, queries);


            bool[] expected = new bool[] { true, false, true };

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] candiesCount = new int[] { 5, 2, 6, 4, 1 };
            int[][] queries = new int[][]{
                new int[] { 3,1,2 },
                new int[] { 4,10,3 },
                new int[] { 3, 10, 100 },
                new int[] { 4, 100, 30 },
                new int[] { 1, 3, 1}
            };
            _1744_CanYouEatYourFavoriteCandyOnYourFavoriteDay canYouEatYourFavoriteCandyOnYourFavoriteDay = new _1744_CanYouEatYourFavoriteCandyOnYourFavoriteDay();
            bool[] result = canYouEatYourFavoriteCandyOnYourFavoriteDay.CanEat(candiesCount, queries);


            bool[] expected = new bool[] { false, true, true, false, false };

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }


        [TestMethod]
        public void TestMethod3()
        {
            int[] candiesCount = new int[] { 46, 5, 47, 48, 43, 34, 15, 26, 11, 25, 41, 47, 15, 25, 16, 50, 32, 42, 32, 21, 36, 34, 50, 45, 46, 15, 46, 38, 50, 12, 3, 26, 26, 16, 23, 1, 4, 48, 47, 32, 47, 16, 33, 23, 38, 2, 19, 50, 6, 19, 29, 3, 27, 12, 6, 22, 33, 28, 7, 10, 12, 8, 13, 24, 21, 38, 43, 26, 35, 18, 34, 3, 14, 48, 50, 34, 38, 4, 50, 26, 5, 35, 11, 2, 35, 9, 11, 31, 36, 20, 21, 37, 18, 34, 34, 10, 21, 8, 5 };
            int[][] queries = new int[][] { new int[] { 80, 2329, 69 }, new int[] { 14, 1485, 76 }, new int[] { 33, 2057, 83 }, new int[] { 13, 1972, 27 }, new int[] { 11, 387, 25 }, new int[] { 24, 1460, 47 }, new int[] { 22, 1783, 35 }, new int[] { 1, 513, 33 }, new int[] { 66, 2124, 85 }, new int[] { 19, 642, 26 }, new int[] { 15, 1963, 79 }, new int[] { 93, 722, 96 }, new int[] { 15, 376, 88 }, new int[] { 60, 1864, 89 }, new int[] { 86, 608, 4 }, new int[] { 98, 257, 35 }, new int[] { 35, 651, 47 }, new int[] { 96, 795, 73 }, new int[] { 62, 2077, 18 }, new int[] { 27, 1724, 57 }, new int[] { 34, 1984, 75 }, new int[] { 49, 2413, 95 }, new int[] { 76, 1664, 5 }, new int[] { 28, 38, 13 }, new int[] { 85, 54, 42 }, new int[] { 12, 301, 3 }, new int[] { 62, 2016, 29 }, new int[] { 45, 2316, 37 }, new int[] { 43, 2360, 28 }, new int[] { 87, 192, 98 }, new int[] { 27, 2082, 21 }, new int[] { 74, 762, 37 }, new int[] { 51, 35, 17 }, new int[] { 73, 2193, 4 }, new int[] { 60, 425, 65 }, new int[] { 11, 1522, 58 }, new int[] { 21, 1699, 66 }, new int[] { 42, 1473, 5 }, new int[] { 30, 2010, 48 }, new int[] { 91, 796, 74 }, new int[] { 82, 2162, 31 }, new int[] { 23, 2569, 65 }, new int[] { 24, 684, 23 }, new int[] { 70, 1219, 51 }, new int[] { 5, 1817, 15 }, new int[] { 81, 2446, 34 }, new int[] { 96, 771, 60 }, new int[] { 49, 1171, 60 }, new int[] { 41, 567, 67 }, new int[] { 39, 799, 59 }, new int[] { 90, 957, 81 }, new int[] { 84, 2122, 27 }, new int[] { 82, 1707, 44 }, new int[] { 11, 1889, 20 }, new int[] { 80, 1697, 83 }, new int[] { 24, 1786, 60 }, new int[] { 90, 1847, 99 }, new int[] { 51, 114, 21 }, new int[] { 44, 466, 85 }, new int[] { 56, 469, 20 }, new int[] { 44, 350, 96 }, new int[] { 66, 1946, 10 }, new int[] { 14, 2470, 12 }, new int[] { 69, 1175, 18 }, new int[] { 98, 1804, 25 }, new int[] { 77, 2187, 40 }, new int[] { 89, 2265, 45 }, new int[] { 19, 2246, 45 }, new int[] { 40, 2373, 79 }, new int[] { 60, 2222, 17 }, new int[] { 37, 385, 5 }, new int[] { 97, 1759, 97 }, new int[] { 10, 903, 5 }, new int[] { 87, 842, 45 }, new int[] { 74, 2398, 66 }, new int[] { 62, 49, 94 }, new int[] { 48, 156, 77 }, new int[] { 76, 2310, 80 }, new int[] { 64, 2360, 95 }, new int[] { 70, 1699, 83 }, new int[] { 39, 1241, 66 }, new int[] { 92, 2312, 21 }, new int[] { 63, 2148, 29 }, new int[] { 95, 594, 74 }, new int[] { 89, 90, 51 }, new int[] { 82, 137, 70 }, new int[] { 54, 301, 97 }, new int[] { 15, 819, 43 }, new int[] { 47, 1402, 60 }, new int[] { 17, 2377, 43 }, new int[] { 50, 1937, 95 }, new int[] { 62, 1174, 74 }, new int[] { 67, 1411, 87 }, new int[] { 39, 1151, 48 } };
            _1744_CanYouEatYourFavoriteCandyOnYourFavoriteDay canYouEatYourFavoriteCandyOnYourFavoriteDay = new _1744_CanYouEatYourFavoriteCandyOnYourFavoriteDay();
            bool[] result = canYouEatYourFavoriteCandyOnYourFavoriteDay.CanEat(candiesCount, queries);


            bool[] expected = new bool[] { false, false, false, false, true, false, false, false, false, false, false, true, true, false, true, true, true, true, false, false, false, false, true, false, true, true, false, false, false, true, false, true, false, false, true, false, false, false, false, true, true, false, true, true, false, false, true, true, true, true, true, true, true, false, true, false, true, true, true, true, true, false, false, true, true, false, true, false, false, false, true, true, false, true, false, true, true, false, false, true, false, true, false, true, true, true, true, false, true, false, false, true, true, true };

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

    }
}

using Arrays.LeetCode;
using Xunit;

namespace Arrays.Tests.LeetCode
{
    public class LeetArraysEasyTests
    {

        readonly LeetEasyArrays sut = null;
        public LeetArraysEasyTests()
        {
            sut = new LeetEasyArrays();
        }

        [Theory]
        [InlineData(new int[] { 12, 345, 2, 6, 7896 }, 2)]
        [InlineData(new int[] { 555, 901, 482, 1771 }, 1)]
        public void Test_FindNumbers(int[] numbers, int expected)
        {
            Assert.Equal(expected, sut.FindNumbers(numbers));
        }

        [Theory]
        [InlineData(new int[] { 0, 1, 2, 2, 3 }, 4)]
        [InlineData(new int[] { 1, 1, 2 }, 2)]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 1, 2 }, 2)]
        public void Test_RemoveDuplicates(int[] numbers, int expected)
        {
            var sut = new LeetEasyArrays();
            var actual = sut.RemoveDuplicates(numbers);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(19, true)]
        [InlineData(5, false)]
        public void Test_HappyNumber(int number, bool expected)
        {
            var actual = sut.HappyNumber(number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(19, true)]
        [InlineData(5, false)]
        public void Test_HappyNumberWithFloydCycle(int number, bool expected)
        {
            var actual = sut.HappyNumberWithFloydCycle(number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 10, 20, 35, 50, 75, 80 }, 70, true)]
        [InlineData(new int[] { 1, 2, 7, 9 }, 7, false)]
        public void Test_TwoPointers(int[] array, int number, bool expected)
        {
            var actual = sut.TwoPointers(array, number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        [InlineData(new int[] { 1, 2, 7, 9 }, 19)]
        [InlineData(new int[] { 1, 2, -7, 9 }, 9)]
        public void Test_MaxSubArray(int[] array, int expected)
        {
            var actual = sut.MaxSubArrayBad(array);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        [InlineData(new int[] { 1, 2, 7, 9 }, 19)]
        [InlineData(new int[] { 1, 2, -7, 9 }, 9)]
        [InlineData(new int[] { -2, 1 }, 1)]
        public void Test_MaxSubArrayDP(int[] array, int expected)
        {
            var actual = sut.MaxSubArrayDP(array);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
        [InlineData(new int[] { 2, 1, 10, 0, 12 }, new int[] { 2, 1, 10, 12, 0 })]
        [InlineData(new int[] { 0, 1 }, new int[] { 1, 0 })]
        [InlineData(new int[] { 0, 1, 0 }, new int[] { 1, 0, 0 })]
        [InlineData(new int[] { 1, 0 }, new int[] { 1, 0 })]
        public void Test_MoveZeros(int[] array, int[] expected)
        {
            sut.MoveZeros(array);
            Assert.Equal(expected, array);
        }



        [Theory]
        [InlineData(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
        [InlineData(new int[] { 2, 1, 10, 0, 12 }, new int[] { 2, 1, 10, 12, 0 })]
        [InlineData(new int[] { 0, 1 }, new int[] { 1, 0 })]
        [InlineData(new int[] { 0, 1, 0 }, new int[] { 1, 0, 0 })]
        [InlineData(new int[] { 1, 0 }, new int[] { 1, 0 })]
        [InlineData(new int[] { 1, 0, 1 }, new int[] { 1, 1, 0 })]
        public void Test_MoveZerosShort(int[] array, int[] expected)
        {
            sut.MoveZerosShort(array);
            Assert.Equal(expected, array);
        }

        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
        public void Test_BuyAndSellStock(int[] prices, int expected)
        {
            var actual = sut.BuyAndSellStock(prices);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 7)]
        [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
        public void Test_BuyAndSellStockTwo(int[] prices, int expected)
        {
            var actual = sut.BuyAndSellStockTwo(prices);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("anagram", "nagaram", true)]
        [InlineData("rat", "car", false)]
        [InlineData("", "", true)]
        [InlineData("rat", "tar", true)]
        [InlineData("ac", "bb", false)]
        [InlineData("vbnxkji", "wqdtegp", false)]
        public void Test_IsAnagram(string s, string t, bool expected)
        {
            var actual = sut.IsAnagram(s, t);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 12, 7, 11, 15, 2, 8 }, 9, new int[] { 1, 4 })]
        [InlineData(new int[] { 9, 12, 13, 23, 28, 43, 44, 59, 60, 61, 68, 70, 86, 88, 92, 124, 125, 136, 168, 173, 173, 180, 199, 212, 221, 227, 230, 277, 282, 306, 314, 316, 321, 325, 328, 336, 337, 363, 365, 368, 370, 370, 371, 375, 384, 387, 394, 400, 404, 414, 422, 422, 427, 430, 435, 457, 493, 506, 527, 531, 538, 541, 546, 568, 583, 585, 587, 650, 652, 677, 691, 730, 737, 740, 751, 755, 764, 778, 783, 785, 789, 794, 803, 809, 815, 847, 858, 863, 863, 874, 887, 896, 916, 920, 926, 927, 930, 933, 957, 981, 997 },
                                542, new int[] { 24, 32 })]

        public void Test_TwoSum(int[] numbers, int target, int[] expected)
        {
            var actual = sut.TwoSum(numbers, target);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("aba#c#", "ab", true)]
        [InlineData("ab#c", "ad#c", true)]
        [InlineData("ab##", "c#d#", true)]
        [InlineData("a##c", "#a#c", true)]
        [InlineData("a##c", "c", true)]
        [InlineData("cca##", "c", true)]
        [InlineData("a#c", "a", false)]
        public void Test_BackspaceCompareStack(string s, string t, bool expected)
        {
            var actual = sut.BackspaceCompareStack(s, t);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("aba#c#", "ab", true)]
        [InlineData("ab#c", "ad#c", true)]
        [InlineData("ab##", "c#d#", true)]
        [InlineData("a##c", "#a#c", true)]
        [InlineData("a##c", "c", true)]
        [InlineData("cca##", "c", true)]
        [InlineData("a#c", "a", false)]
        public void Test_BackspaceCompare(string s, string t, bool expected)
        {
            var actual = sut.BackspaceCompare(s, t);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("leetcode", 0)]
        [InlineData("loveleetcode", 2)]
        [InlineData("ababab", -1)]
        [InlineData("abcdefghiklmn", 0)]
        [InlineData("a", 0)]
        [InlineData("", -1)]

        public void Test_FirstUniqueChar(string s, int expected)
        {
            var actual = sut.FirstUniqueChar(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("aA", "aAAbbbb", 3)]
        [InlineData("z", "ZZ", 0)]
        public void Test_NumJewelsInStones(string s, string j, int expected)
        {
            var actual = sut.NumJewelsInStones(s, j);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("a", "b", false)]
        [InlineData("aa", "ab", false)]
        [InlineData("aa", "aab", true)]
        public void Test_CanConstruct(string note, string magazine, bool expected)
        {
            var actual = sut.CanConstruct(note, magazine);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 3 }, 3)]
        [InlineData(new int[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
        public void Test_MajorityElement(int[] nums, int expected)
        {
            var actual = sut.MajorityElement(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 4, 2, 3 }, true)]
        [InlineData(new int[] { 4 }, true)]
        [InlineData(new int[] { 4, 3 }, true)]
        [InlineData(new int[] { 4, 2, 1 }, false)]
        [InlineData(new int[] { 3, 4, 2, 3 }, false)]
        public void Test_CheckPossibility(int[] nums, bool expected)
        {
            var actual = sut.CheckPossibility(nums);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_CheckStraightLine()
        {
            var grid = new int[6][];
            grid[0] = new int[] { 1, 1 };
            grid[1] = new int[] { 2, 2 };
            grid[2] = new int[] { 3, 4 };
            grid[3] = new int[] { 4, 5 };
            grid[4] = new int[] { 5, 6 };
            grid[5] = new int[] { 7, 7 };
            var actual = sut.CheckStraightLine(grid);
            Assert.False(actual);
        }

        [Fact]
        public void Test_CheckStraightLine2()
        {
            var grid = new int[6][];
            grid[0] = new int[] { 1, 2 };
            grid[1] = new int[] { 2, 3 };
            grid[2] = new int[] { 3, 4 };
            grid[3] = new int[] { 4, 5 };
            grid[4] = new int[] { 5, 6 };
            grid[5] = new int[] { 6, 7 };
            var actual = sut.CheckStraightLine(grid);
            Assert.True(actual);
        }

        [Fact]
        public void Test_CheckStraightLine3()
        {
            var grid = new int[5][];
            grid[0] = new int[] { -3, -2 };
            grid[1] = new int[] { -1, -2 };
            grid[2] = new int[] { 2, -2 };
            grid[3] = new int[] { -2, -2 };
            grid[4] = new int[] { 0, -2 };

            var actual = sut.CheckStraightLine(grid);
            Assert.True(actual);
        }

        [Fact]
        public void Test_CheckStraightLine4()
        {
            var grid = new int[5][];
            grid[0] = new int[] { -4, -3 };
            grid[1] = new int[] { 1, 0 };
            grid[2] = new int[] { 3, -1 };
            grid[3] = new int[] { 0, -1 };
            grid[4] = new int[] { -5, 2 };

            var actual = sut.CheckStraightLine(grid);
            Assert.False(actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 0, 1, 1, 1 }, 3)]
        [InlineData(new int[] { 0 }, 0)]
        [InlineData(new int[] { 1 }, 1)]
        public void Test_FindMaxConsecutiveOnes(int[] nums, int expected)
        {
            var actual = sut.FindMaxConsecutiveOnes(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { -4, -1, 0, 3, 10 }, new int[] { 0, 1, 9, 16, 100 })]
        [InlineData(new int[] { -7, -3, 2, 3, 11 }, new int[] { 4, 9, 9, 49, 121 })]
        [InlineData(new int[] { -14, -11, 0, 1, 3, 11 }, new int[] { 0, 1, 9, 121, 121, 196 })]
        public void Test_SortedSquares(int[] nums, int[] expected)
        {
            var actual = sut.SortedSquares(nums);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 }, new int[] { 1, 0, 0, 2, 3, 0, 0, 4 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 1, 2, 0, 3, 0, 7, 9, 8 }, new int[] { 1, 2, 0, 0, 3, 0, 0, 7 })]
        [InlineData(new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { 1, 1, 0, 0 }, new int[] { 1, 1, 0, 0 })]
        [InlineData(new int[] { 8, 4, 5, 0, 0, 0, 0, 7 }, new int[] { 8, 4, 5, 0, 0, 0, 0, 0 })]
        [InlineData(new int[] { 9, 9, 9, 4, 8, 0, 0, 3, 7, 2, 0, 0, 0, 0, 9, 1, 0, 0, 1, 1, 0, 5, 6, 3, 1, 6, 0, 0, 2, 3, 4, 7, 0, 3, 9, 3, 6, 5, 8, 9, 1, 1, 3, 2, 0, 0, 7, 3, 3, 0, 5, 7, 0, 8, 1, 9, 6, 3, 0, 8, 8, 8, 8, 0, 0, 5, 0, 0, 0, 3, 7, 7, 7, 7, 5, 1, 0, 0, 8, 0, 0 },
            new int[] { 9, 9, 9, 4, 8, 0, 0, 0, 0, 3, 7, 2, 0, 0, 0, 0, 0, 0, 0, 0, 9, 1, 0, 0, 0, 0, 1, 1, 0, 0, 5, 6, 3, 1, 6, 0, 0, 0, 0, 2, 3, 4, 7, 0, 0, 3, 9, 3, 6, 5, 8, 9, 1, 1, 3, 2, 0, 0, 0, 0, 7, 3, 3, 0, 0, 5, 7, 0, 0, 8, 1, 9, 6, 3, 0, 0, 8, 8, 8, 8, 0 })]

        public void Test_DuplicateZeros(int[] nums, int[] expected)
        {
            sut.DuplicateZeros(nums);
            Assert.Equal(expected, nums);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(new int[] { 1, 0 }, 1, new int[] { 1 }, 1, new int[] { 1, 1 })]
        [InlineData(new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 })]
        [InlineData(new int[] { 1, 2, 3, 0 }, 3, new int[] { 1 }, 1, new int[] { 1, 1, 2, 3 })]
        [InlineData(new int[] { 2, 0 }, 1, new int[] { 1 }, 1, new int[] { 1, 2 })]
        public void Test_Merge(int[] nums, int nums1length, int[] nums2, int nums2length, int[] expected)
        {
            sut.Merge(nums, nums1length, nums2, nums2length);
            Assert.Equal(expected, nums);
        }

        [Theory]
        [InlineData("a", "a")]
        [InlineData("abc", "cba")]
        [InlineData("ab", "ba")]
        [InlineData("hello", "olleh")]
        [InlineData("Hannah", "hannaH")]
        public void Test_ReverseString(string s1, string expected)
        {
            var s1chararray = s1.ToCharArray();
            sut.ReverseString(s1chararray);
            var actual = new string(s1chararray);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 12, -5, -6, 50, 3 }, 4, 12.75)]
        [InlineData(new int[] { -5, -6, 5, -3 }, 2, 1.0)]
        //[InlineData(new int[] { 1 }, 1)]
        public void Test_FindMaxAverage(int[] nums, int k, double expected)
        {
            var actual = sut.FindMaxAverage(nums, k);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 1, 2 })]
        [InlineData(new int[] { 12, 13, 23, 28, 43, 44, 59, 60, 61, 68, 70, 86, 88, 92, 124, 125, 136, 168, 173, 173, 180, 199, 212, 221, 227, 230, 277,
            282, 306, 314, 316, 321, 325, 328, 336, 337, 363, 365, 368, 370, 370, 371, 375, 384, 387, 394, 400, 404, 414, 422, 422, 427, 430, 435, 457,
            493, 506, 527, 531, 538, 541, 546, 568, 583, 585, 587, 650, 652, 677, 691, 730, 737, 740, 751, 755, 764, 778, 783, 785, 789, 794, 803, 809,
            815, 847, 858, 863, 863, 874, 887, 896, 916, 920, 926, 927, 930, 933, 957, 981, 997 }, 542, new int[] { 24, 32 })]
        //[]

        public void Test_TwoSum2(int[] numbers, int target, int[] expected)
        {
            var actual = sut.TwoSum2(numbers, target);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(new int[] { 34, 23, 1, 24, 75, 33, 54, 8 }, 60, 58)]
        [InlineData(new int[] { 0, 20, 30 }, 15, -1)]
        [InlineData(new int[] { 254,914,110,900,147,441,209,122,571,942,136,350,160,127,178,839,201,386,462,45,735,467,153,415,875,282,204,534,639,994,284,
                                320,865,468,1,838,275,370,295,574,309,268,415,385,786,62,359,78,854,944 }, 200, 198)]
        public void Test_TwoSumLessThanK(int[] nums, int k, int expected)
        {
            var actual = sut.TwoSumLessThanK(nums, k);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, new int[] { 1 }, new int[] { 1, 1 },
            new int[] { 1, 2, 1 }, new int[] { 1, 3, 3, 1 })]
        [InlineData(4, new int[] { 1 }, new int[] { 1, 1 }, new int[] { 1, 2, 1 },
            new int[] { 1, 3, 3, 1 }, new int[] { 1, 4, 6, 4, 1 })]
        [InlineData(0, new int[] { 1 })]
        [InlineData(1, new int[] { 1 }, new int[] { 1, 1 })]
        public void Test_GeneratePascalTriangle(int numRows, params int[][] expected)
        {
            var actual = sut.Generate(numRows);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, new int[] { 1, 3, 3, 1 })]
        [InlineData(4, new int[] { 1, 4, 6, 4, 1 })]
        [InlineData(0, new int[] { 1 })]
        [InlineData(1, new int[] { 1, 1 })]
        public void Test_GetRowPascalTriangle(int rowIndex, int[] expected)
        {
            var actual = sut.GetRow(rowIndex);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(2, 1)]
        [InlineData(1, 1)]
        public void Test_Fibonacci(int n, int expected)
        {
            var actual = sut.Fibonacci(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 3)]
        [InlineData(4, 5)]
        [InlineData(2, 2)]
        [InlineData(1, 1)]
        [InlineData(44, 1134903170)]
        public void Test_ClimbStairs(int n, int expected)
        {
            var actual = sut.ClimbStairs(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1789", "15", "1804")]
        [InlineData("11", "22", "33")]
        [InlineData("999", "0", "999")]
        [InlineData("99", "9", "108")]
        [InlineData("999", "888", "1887")]
        public void Test_AddStrings(string num1, string num2, string expected)
        {
            var actual = sut.AddStrings(num1, num2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 3, 1 }, new int[] { 3, 3 }, new int[] { 3 })]
        [InlineData(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }, new int[] { 9, 4 })]
        [InlineData(new int[] { 1 }, new int[] { 2 }, new int[] { })]
        [InlineData(new int[] { 1 }, new int[] { 1 }, new int[] { 1 })]
        public void Test_Intersection(int[] nums1, int[] nums2, int[] expected)
        {
            var actual = sut.Intersection(nums1, nums2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 3, 3 }, new int[] { 3, 3 }, new int[] { 3 })]
        [InlineData(new int[] { 4, 5, 9 }, new int[] { 9, 4, 9, 8, 4 }, new int[] { 4, 9 })]
        [InlineData(new int[] { 1 }, new int[] { 2 }, new int[] { })]
        [InlineData(new int[] { 1 }, new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 1, 1, 2, 2, 2 }, new int[] { }, new int[] { })]
        [InlineData(new int[] { }, new int[] { }, new int[] { })]
        [InlineData(new int[] { -2, -1, -1, -1, 0, 0, 1 }, new int[] { -1, -1, 1 }, new int[] { -1, 1 })]
        [InlineData(new int[] { 7, 2, 2, 4, 7, 0, 3, 4, 5 }, new int[] { 3, 9, 8, 6, 1, 9 }, new int[] { 3 })]


        public void Test_IntersectionSorted(int[] nums1, int[] nums2, int[] expected)
        {
            var actual = sut.IntersectionSorted(nums1, nums2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 3, 1 }, new int[] { 3, 3 }, new int[] { 3, 3 })]
        [InlineData(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }, new int[] { 4, 9 })]
        [InlineData(new int[] { 1 }, new int[] { 2 }, new int[] { })]
        [InlineData(new int[] { 1 }, new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 1, 1, 2, 2, 2 }, new int[] { }, new int[] { })]
        [InlineData(new int[] { }, new int[] { }, new int[] { })]
        [InlineData(new int[] { -2, -1, -1, -1, 0, 0, 1 }, new int[] { -1, -1, 1 }, new int[] { -1, -1, 1 })]
        [InlineData(new int[] { 7, 2, 2, 4, 7, 0, 3, 4, 5 }, new int[] { 3, 9, 8, 6, 1, 9 }, new int[] { 3 })]
        [InlineData(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }, new int[] { 2, 2 })]
        public void Test_Intersection2(int[] nums1, int[] nums2, int[] expected)
        {
            var actual = sut.Intersection2(nums1, nums2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(new int[] { 1, 0 }, 1, new int[] { 1 }, 1, new int[] { 1, 1 })]
        [InlineData(new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 })]
        [InlineData(new int[] { 1, 2, 3, 0 }, 3, new int[] { 1 }, 1, new int[] { 1, 1, 2, 3 })]
        [InlineData(new int[] { 2, 0 }, 1, new int[] { 1 }, 1, new int[] { 1, 2 })]
        [InlineData(new int[] { 1, 0 }, 1, new int[] { 2 }, 1, new int[] { 1, 2 })]
        public void Test_MergeRepeat(int[] nums, int nums1length, int[] nums2, int nums2length, int[] expected)
        {
            var actual = sut.MergeRepeat(nums, nums1length, nums2, nums2length);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 2, 3 },true)]
        [InlineData(new int[] { 6, 5, 4, 4 }, true)]
        [InlineData(new int[] { 1,3,2 }, false)]
        [InlineData(new int[] { -4, -3, 2, 2 }, true)]
        [InlineData(new int[] { 1, 1,1 }, true)]
        public void Test_IsMonotonic(int[] nums, bool expected)
        {
            var actual = sut.IsMonotonic(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("([)]", false)]
        [InlineData("{[]}", true)]
        [InlineData("([{{(", false)]
        [InlineData("(", false)]
        [InlineData("]", false)]
        public void Test_IsValid(string s, bool expected)
        {
            var actual = sut.IsValid(s);
            Assert.Equal(expected, actual);
        }
        
    }
}

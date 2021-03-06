﻿using Arrays.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Arrays.Tests.LeetCode
{
    public class LeetArraysMediumTests
    {
       readonly LeetMediumArrays sut;
        public LeetArraysMediumTests()
        {
            sut = new LeetMediumArrays();
        }
        [Theory]
        [InlineData(new string[] { "cab", "tin", "pew", "duh", "may", "ill", "buy", "bar", "max", "doc" }, 10)]
        [InlineData(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" }, 3)]
        [InlineData(new string[] { "duh", "ill" }, 2)]
        public void Test_GroupAnagrams(string[] strs, int expected)
        {
            var actual = sut.GroupAnagrams(strs);
            Assert.Equal(expected, actual.Count);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 2)]
        [InlineData(new int[] { 1, 1, 3, 3, 5, 5, 7, 7 }, 0)]
        [InlineData(new int[] { 1, 3, 2, 3, 5, 0 }, 3)]
        [InlineData(new int[] { 1, 1, 2, 2 }, 2)]
        [InlineData(new int[] { 1, 1, 2, }, 2)]
        public void Test_CountElements(int[] elements, int expected)
        {
            var actual = sut.CountElements(elements);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 0 }, 0)]
        [InlineData(new int[] { 0, 0 }, 0)]
        [InlineData(new int[] { 0, 1 }, 2)]
        [InlineData(new int[] { 0, 1, 0 }, 2)]
        [InlineData(new int[] { 0, 1, 1 }, 2)]
        [InlineData(new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0 }, 8)]
        [InlineData(new int[] { 0, 1, 1, 1, 1, 1, 0, 0, 0 }, 6)]
        public void Test_FindMaxLength(int[] nums, int expected)
        {
            var actual = sut.FindMaxLength(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 0 }, 0)]
        [InlineData(new int[] { 0, 0 }, 0)]
        [InlineData(new int[] { 0, 1 }, 2)]
        [InlineData(new int[] { 0, 1, 0 }, 2)]
        [InlineData(new int[] { 0, 1, 1 }, 2)]
        [InlineData(new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0 }, 8)]
        [InlineData(new int[] { 0, 1, 1, 1, 1, 1, 0, 0, 0 }, 6)]
        public void Test_FindMaxLengthBetter(int[] nums, int expected)
        {
            var actual = sut.FindMaxLengthBetter(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
        public void Test_ProductExceptSelf(int[] numbers, int[] expected)
        {
            var actual = sut.ProductExceptSelf(numbers);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("()", true)]
        [InlineData("(*)", true)]
        [InlineData("(*))", true)]
        [InlineData("(*()", true)]
        [InlineData("(((******))", true)]
        [InlineData("(())((())()()(*)(*()(())())())()()((()())((()))(*", false)]

        public void Test_CheckValidString(string s, bool expected)
        {
            var actual = sut.CheckValidString(s);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test_NumIslands()
        {
            var matrix = new char[4][];
            matrix[0] = new char[] { '1', '1', '1', '1', '0' };
            matrix[1] = new char[] { '1', '1', '0', '1', '0' };
            matrix[2] = new char[] { '1', '1', '0', '0', '0' };
            matrix[3] = new char[] { '0', '0', '0', '0', '0' };
            var actual = sut.NumIslands(matrix);
            Assert.Equal(1, actual);
        }

        [Fact]
        public void Test_NumIslands2()
        {
            var matrix = new char[4][];
            matrix[0] = new char[] { '1', '1', '0', '0', '0' };
            matrix[1] = new char[] { '1', '1', '0', '0', '0' };
            matrix[2] = new char[] { '0', '0', '1', '0', '0' };
            matrix[3] = new char[] { '0', '0', '0', '1', '1' };
            var actual = sut.NumIslands(matrix);
            Assert.Equal(3, actual);
        }
        [Fact]
        public void Test_NumIslands3()
        {
            var matrix = new char[3][];
            matrix[0] = new char[] { '1', '1', '1' };
            matrix[1] = new char[] { '0', '1', '0' };
            matrix[2] = new char[] { '1', '1', '1' };
            var actual = sut.NumIslands(matrix);
            Assert.Equal(1, actual);
        }

        [Fact]
        public void Test_MinPathSum()
        {
            var matrix = new int[3][];
            matrix[0] = new int[] { 1, 3, 1 };
            matrix[1] = new int[] { 1, 5, 1 };
            matrix[2] = new int[] { 4, 2, 1 };
            var actual = sut.MinPathSum(matrix);
            Assert.Equal(7, actual);
        }

        [Fact]
        public void Test_MinPathSum2()
        {
            var matrix = new int[2][];
            matrix[0] = new int[] { 1, 2 };
            matrix[1] = new int[] { 1, 1 };

            var actual = sut.MinPathSum(matrix);
            Assert.Equal(3, actual);
        }

        [Fact]
        public void Test_MinPathSum3()
        {
            var matrix = new int[2][];
            matrix[0] = new int[] { 1, 2, 5 };
            matrix[1] = new int[] { 3, 2, 1 };

            var actual = sut.MinPathSum(matrix);
            Assert.Equal(6, actual);
        }

        [Fact]
        public void Test_MinPathSum4()
        {
            var matrix = new int[1][];
            matrix[0] = new int[] { 9, 1, 4, 8 };

            var actual = sut.MinPathSum(matrix);
            Assert.Equal(22, actual);
        }

        [Fact]
        public void Test_MinPathSum5()
        {
            var matrix = new int[3][];
            matrix[0] = new int[] { 9 };
            matrix[1] = new int[] { 2 };
            matrix[2] = new int[] { 4 };

            var actual = sut.MinPathSum(matrix);
            Assert.Equal(15, actual);
        }

        [Theory]
        [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
        [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
        [InlineData(new int[] { 1 }, 1, 0)]
        [InlineData(new int[] { 1 ,3}, 3, 1)]
        public void Test_SearchRotatedArray(int[] numbers, int target, int expected)
        {
            var actual = sut.SearchRotatedArray(numbers, target);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] {1,1,1 }, 2,2 )]
        [InlineData(new int[] { 1 }, 2,0 )]
        [InlineData(new int[] { 1 }, 1 ,1)]
        [InlineData(new int[] { 1,2,3 }, 3, 2)]
        [InlineData(new int[] { 1 }, 0, 0)]
        [InlineData(new int[] { -1,-1,1 }, 0, 1)]
        public void Test_SubarraySum(int[] nums, int k, int expected)
        {
            var actual = sut.SubarraySum(nums, k);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 2,3,1,1,4},true)]
        [InlineData(new int[] { 3,2,1,0,4 },false)]
 
        public void Test_CanJump(int[] nums, bool expected)
        {
            var actual = sut.CanJump(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("a", "a")]
        [InlineData("aa", "aa")]
        [InlineData("ac", "a")]
        [InlineData("babad", "bab")]
        [InlineData("cbbd", "bb")]
        [InlineData("abbacab", "bacab")]

        public void Test_LongestPalindrome(string val, string expected)
        {
            var actual = sut.LongestPalindrome(val);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 }, 2)]
        [InlineData(new int[] { 3, 3, 7, 7, 10, 11, 11 }, 10)]
         public void Test_SingleNonDuplicate(int[] nums, int expected)
        {
            var actual = sut.SingleNonDuplicate(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, -2, 3, -2 }, 3)]
        [InlineData(new int[] { 5,-3,5}, 10)]
        [InlineData(new int[] { 3,-1,2,-1}, 4)]
        [InlineData(new int[] { 3, -2, 2, -3 }, 3)]
        [InlineData(new int[] { -3, -1, -2 }, -1)]
        public void Test_MaxSubarraySumCircular(int[] nums, int expected)
        {
            var actual = sut.MaxSubarraySumCircular(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("cbaebabacd","abc", new int[] { 0, 6 })]
        [InlineData("cbaebabc", "abc", new int[] { 0, 5 })]
        [InlineData("abab", "ab", new int[] { 0,1,2})]
        [InlineData("abc", "ab", new int[] { 0 })]
        public void Test_FindAnagrams(string s, string p, int[] expected)
        {
            var actual = sut.FindAnagrams(s,p);
            Assert.Equal(expected, actual.ToArray());
        }

        [Theory]
        [InlineData("ab", "eidbaooo", true)]
        [InlineData("abab", "eidboaoo",false)]
        [InlineData("ab", "eidboaooba", true)]
        [InlineData("ab", "eba", true)]
        public void Test_CheckInclusion(string s, string p, bool expected)
        {
            var actual = sut.CheckInclusion(s, p);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("tree", "eetr")]
        [InlineData("cccaaa", "cccaaa")]
        [InlineData("Aabb", "bbAa")]
        [InlineData("a", "a")]
        public void Test_FrequencySort(string s, string expected)
        {
            var actual = sut.FrequencySort(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { -1, 0, 1, 2, -1, -4 }, new int[] { -1, 0, 1 }, new int[] { 2, -1, -1 })]
        [InlineData(new int[] { 1,2,-2,-1 }, new int[] {})]
        [InlineData(new int[] { 1, 2, -1, 6 }, new int[] { })]
        public void Test_ThreeSum(int[] nums, params int[][] expected)
        {
            var actual = sut.ThreeSum(nums);
            Assert.Equal(expected, actual);
        }
        

    }
}

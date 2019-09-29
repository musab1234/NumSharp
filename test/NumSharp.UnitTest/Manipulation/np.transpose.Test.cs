﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumSharp.UnitTest.Utilities;

namespace NumSharp.UnitTest.Manipulation
{
    [TestClass]
    public class np_transpose_Test
    {
        [TestMethod]
        public void Case1()
        {
            var nd = np.array(1, 2, 3, 4).reshape(2, 2);
            np.transpose(nd).Should()
                .BeOfValues(1, 3, 2, 4).And.BeShaped(2, 2);
        }

        [TestMethod]
        public void Case2()
        {
            var nd = np.arange(3 * 2 * 4).reshape(3, 2, 4);
            np.transpose(nd).Should()
                .BeOfValues(0, 8, 16, 4, 12, 20, 1, 9, 17, 5, 13, 21, 2, 10, 18, 6, 14, 22, 3, 11, 19, 7, 15, 23)
                .And.BeShaped(4, 2, 3);
        }

        [TestMethod]
        public void Case3()
        {
            var nd = np.arange(2 * 3).reshape(1, 2, 3);
            np.transpose(nd, new int[] {1, 0, 2}).Should()
                .BeOfValues(0, 1, 2, 3, 4, 5)
                .And.BeShaped(2, 1, 3);
        }
    }
}

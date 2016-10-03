﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using BigPrimeNumber.Primality.Deterministic;
using BigPrimeNumber.Primality.Heuristic;
using Xunit;

namespace BigPrimeNumberTests.Primality.Deterministic
{
    public class NaiveTestTest
    {
        [Fact]
        public async Task Test_Prime13_ReturnsTrue()
        {
            var test = new NaiveTest();
            var result = await test.TestAsync(new BigInteger(13));

            Assert.True(result);
        }
    }
}

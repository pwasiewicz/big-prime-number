﻿using System.Numerics;
using System.Threading.Tasks;
using BigPrimeNumber.Helpers;
using BigPrimeNumber.Tools;

namespace BigPrimeNumber.Primality.Deterministic
{
    public class NaiveTest  : PrimalityTest
    {
        public override async Task<bool> TestAsync(BigInteger source)
        {
            var trivialCheck = this.CheckEdgeCases(source);
            if (trivialCheck.HasValue) return trivialCheck.Value;

            var sourceSquareRoot = BigMath.SquareRoot(source);

            var isPrime = true;

            await Task.Run(() =>
            {
                for (var i = BigIntegerHelpers.Two; i <= sourceSquareRoot; i = BigInteger.Add(i, BigInteger.One))
                {
                    var rem = BigInteger.Remainder(source, i);

                    if (rem != BigInteger.Zero) continue;

                    isPrime = false;
                    break;
                }
            });

            return isPrime;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Security.Cryptography;

namespace TI_laba4
{
    class WorkWithBigInt
    {
        public static BigInteger getRandom(BigInteger Fi)
        {
            BigInteger e;
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buf = new byte[Fi.ToByteArray().Length];
            do
            {
                rng.GetBytes(buf);
                e = new BigInteger(buf);
            } while ((e > Fi) || (e <= 2));
            return e;
        }

        private static bool MillerTest(BigInteger d, BigInteger n)
        {
            // Pick a random number in [2..n-2]
            // Corner cases make sure that n > 4
            BigInteger a = getRandom(n - 2);


            // Compute a^d % n          
            BigInteger x = BigInteger.ModPow(a, d, n);

            if (x == 1 || x == n - 1)
                return true;

            // Keep squaring x while one of the following doesn't
            // happen
            // (i)   d does not reach n-1
            // (ii)  (x^2) % n is not 1
            // (iii) (x^2) % n is not n-1
            while (d != n - 1)
            {
                x = (x * x) % n;
                d *= 2;

                if (x == 1)
                    return false;
                if (x == n - 1)
                    return true;
            }
            // Return composite
            return false;
        }

        public static bool IsPrime(BigInteger n, int k)
        {
            if (n <= 1 || n == 4)
                return false;
            if (n <= 3)
                return true;

            // Find r such that n = 2^d * r + 1 for some r >= 1
            BigInteger d = n - 1;
            while (d % 2 == 0)
                d /= 2;

            // Iterate given nber of 'k' times
            for (int i = 0; i < k; i++)
                if (MillerTest(d, n) == false)
                    return false;
            return true;
        }
    }
}

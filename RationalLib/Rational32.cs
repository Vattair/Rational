using System;

namespace RationalLib
{
    // immutable
    public readonly struct Rational32
    {
        private readonly int numerator;
        public int Numerator => numerator;

        private readonly int denominator;
        public int Denominator => denominator;

        #region stałe i properties
        public static Rational32 ZERO;// = new Rational32(0,1);
        public static Rational32 ONE;
        public static Rational32 HALF;
        #endregion

        #region constructors
        public Rational32(int numerator, int denominator = 1)
        {

            var gcd = GreatestCommonDivisor(numerator, denominator);
            if (denominator < 0)
            {
                gcd *= -1;
            }

            this.numerator = numerator / gcd;
            this.denominator = denominator /gcd;
        }

        static Rational32()
        {
            ZERO = new Rational32(0, 1);
            ONE = new Rational32(1, 1);
            HALF = new Rational32(1, 2);
        }
        #endregion

        //Największy wspólny dzielnik
        private static int GreatestCommonDivisor(int x, int y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);

            while (y != 0)
            {
                int z = x % y;
                x = y;
                y = z;
            }

            return x;
        }

        public override string ToString() => $"{Numerator}/{Denominator}";

    }
}

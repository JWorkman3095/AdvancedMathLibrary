using System;

namespace AdvancedMathLibrary {

    public static class Math {

        public const int Zero = 0;

        public static int AbsoluteValue(int x) {
            // If x is less that zero returns a neg number return it as positive
            // ternary statment -a statement that you can rewrite in a diff way           
            return (x < 0) ? -x : x;
            /* rewritten
             if (x < 0) {
                return -x;
              } else {
                return x;
              }
             */
        }

        public static int Add(int x, int y) {
            return x + y;
        }
        public static int Subtract(int x, int y) {
            return x - y;
        }
        public static int Mutiply(int x, int y) {
            return x * y;
        }
        public static int Divide(int x, int y) {
            return x / y;
        }
    }
}

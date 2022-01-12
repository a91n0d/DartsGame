using System;

namespace DartsGame
{
    public static class Darts
    {
        public const int OUTERCIRCLERADIUS = 10;
        public const int MIDDLECIRCLERADIUS = 5;
        public const int INNERCIRCLERADIUS = 1;
        public const int POINTSFOROUTCIRCLE = 1;
        public const int POINTSFORMIDDLECIRCLE = 5;
        public const int POINTSFORINNERCIRCLE = 10;

        /// <summary>
        /// Calculates the earned points in a single toss of a Darts game.
        /// </summary>
        /// <param name="x">x-coordinate of dart.</param>
        /// <param name="y">y-coordinate of dart.</param>
        /// <returns>The earned points.</returns>
        public static int GetScore(double x, double y)
        {
            bool landsOuterCircle = (Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(OUTERCIRCLERADIUS, 2);
            bool landsMiddleCircle = (Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(MIDDLECIRCLERADIUS, 2);
            bool landsInnerCircle = (Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(INNERCIRCLERADIUS, 2);
            if (landsInnerCircle)
            {
                return POINTSFORINNERCIRCLE;
            }

            if (landsMiddleCircle)
            {
                return POINTSFORMIDDLECIRCLE;
            }

            if (landsOuterCircle)
            {
                return POINTSFOROUTCIRCLE;
            }

            return 0;
        }
    }
}

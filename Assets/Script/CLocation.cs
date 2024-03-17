namespace Script
{
    public struct CLocation
    {
        public int X;
        public int Y;

        public CLocation(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return "[" + X + "," + Y + "]";
        }
    }
}
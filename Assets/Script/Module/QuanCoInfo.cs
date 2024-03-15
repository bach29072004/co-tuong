namespace Script.Module
{
    public class QuanCoInfo
    {
        public string Path;
        public string Name;
        public int X;
        public int Y;

        public QuanCoInfo(string name, string path, int x, int y)
        {
            Path = path;
            Name = name;
            X = x;
            Y = y;
        }
    }
}
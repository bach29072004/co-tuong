namespace Script
{
    public class InfoNguoiChoi
    {
        public string name;
        public int eloCoTuong;
        public int eloCoUp;
        public int winCoTuong;
        public int winCoUp;

        public InfoNguoiChoi(string name, int eloCoTuong, int eloCoUp, int winCoTuong, int winCoUp)
        {
            this.name = name;
            this.eloCoTuong = eloCoTuong;
            this.eloCoUp = eloCoUp;
            this.winCoTuong = winCoTuong;
            this.winCoUp = winCoUp;
        }
    }
}
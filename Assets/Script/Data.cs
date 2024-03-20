using System.Collections.Generic;

namespace Script
{
    public class Data
    {
        private static Data _instance;

        public static Data Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Data();
                }

                return _instance;
            }
        }

        public List<string> ListNotifyData = new List<string>();
    }
}
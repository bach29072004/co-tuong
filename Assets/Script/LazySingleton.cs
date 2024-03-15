using UnityEngine;
namespace Script
{
    public class LazySingleton : MonoBehaviour
    {
        private static LazySingleton _instance;

        public static LazySingleton instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LazySingleton();
                }

                return _instance;
            }
        }

        protected LazySingleton()
        {
            
        }
    }
}
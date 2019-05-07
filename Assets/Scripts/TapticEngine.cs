using System.Runtime.InteropServices;
using UnityEngine;

namespace UnityModule.HapticFeedback
{
    public static class TapticEngine
    {
#if UNITY_IOS
        [DllImport("__Internal")]
        private static extern void _Impact(int mode);

        [DllImport("__Internal")]
        private static extern void _Notification(int mode);

        [DllImport("__Internal")]
        private static extern void _Selection();
#endif
        
        public static void Impact(TapticImpactType type)
        {
#if UNITY_IOS
            if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                _Impact((int)type);
            }
#endif
        }

        public static void Selection()
        {
#if UNITY_IOS
            if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                _Selection();
            }
#endif
        }

        public static void Notification(TapticNotificationType type)
        {
#if UNITY_IOS
            if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                _Notification((int)type);
            }
#endif
        }
    }
}

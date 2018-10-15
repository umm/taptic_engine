using System.Runtime.InteropServices;
using UnityEngine;

namespace UnityModule.HapticFeedback
{
    public static class TapticEngine
    {
        [DllImport("__Internal")]
        private static extern void _Impact(int mode);

        [DllImport("__Internal")]
        private static extern void _Notification(int mode);

        [DllImport("__Internal")]
        private static extern void _Selection();
        
        public static void Impact(TapticImpactType type)
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                _Impact((int)type);
            }
        }

        public static void Selection()
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                _Selection();
            }
        }

        public static void Notification(TapticNotificationType type)
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                _Notification((int)type);
            }
        }
    }
}
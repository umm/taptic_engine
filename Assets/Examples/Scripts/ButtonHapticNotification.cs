using UnityEngine;
using UnityEngine.UI;
using UnityModule.HapticFeedback;

namespace Example.UnityModule.HapticFeedback
{
    [RequireComponent(typeof(Button))]
    public class ButtonHapticNotification : MonoBehaviour
    {
        public TapticNotificationType NotificationType = TapticNotificationType.Success;

        void Start()
        {
            this.GetComponent<Button>().onClick.AddListener(() => TapticEngine.Notification(this.NotificationType));
        }
    }
}
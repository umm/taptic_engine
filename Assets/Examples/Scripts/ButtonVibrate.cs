using UnityEngine;
using UnityEngine.UI;

namespace Example.UnityModule.HapticFeedback
{
    [RequireComponent(typeof(Button))]
    public class ButtonVibrate : MonoBehaviour
    {
        void Start()
        {
            this.GetComponent<Button>().onClick.AddListener(() =>
            {
                Handheld.Vibrate();
            });
        }
    }
}
using UnityEngine;
using UnityEngine.UI;
using UnityModule.HapticFeedback;

namespace Example.UnityModule.HapticFeedback
{
    [RequireComponent(typeof(Button))]
    public class ButtonHapticSelection : MonoBehaviour
    {
        void Start()
        {
            this.GetComponent<Button>().onClick.AddListener(() => TapticEngine.Selection());
        }
    }
}
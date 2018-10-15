using UnityEngine;
using UnityEngine.UI;
using UnityModule.HapticFeedback;

namespace Example.UnityModule.HapticFeedback
{
    [RequireComponent(typeof(Button))]
    public class ButtonHapticImpact : MonoBehaviour
    {
        public TapticImpactType ImpactType = TapticImpactType.Heavy;

        void Start()
        {
            this.GetComponent<Button>().onClick.AddListener(() => TapticEngine.Impact(this.ImpactType));
        }
    }
}
using UnityEngine;

namespace Scripts.UI.Common.StateViewers
{
    [RequireComponent(typeof(CanvasGroup))]
    public class CanvasGroupStateViewer : MonoBehaviour, IStateViewer
    {
        private CanvasGroup _canvasGroup;

        private void Awake() => _canvasGroup = GetComponent<CanvasGroup>();

        public void Enable() => _canvasGroup.alpha = 1.0f;
        public void Disable() => _canvasGroup.alpha = 0.0f;
    }
}
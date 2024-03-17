using UnityEngine;

namespace Scripts.UI.Common.StateViewers
{
    public class CanvasGroupStateViewer : MonoBehaviour, IStateViewer
    {
        [SerializeField] private CanvasGroup _canvasGroup;

        // TODO: Check Awake() { _canvasGroup = GetComponent<CanvasGroup>(); }

        public void Enable() => _canvasGroup.alpha = 1.0f;
        public void Disable() => _canvasGroup.alpha = 0.0f;
    }
}
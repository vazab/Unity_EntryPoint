using UnityEngine;
using Scripts.UI.Common.StateViewers;
using Scripts.Utilities;

namespace Scripts.Infrastructure
{
    public class GameBootstrapper : MonoBehaviour, ICoroutineRunner
    {
        [SerializeField] private CanvasGroupStateViewer _loadCurtain;

        private void Awake()
        {
            DontDestroyOnLoad(_loadCurtain);
            Game game = new Game(_loadCurtain, this);
            game.Start();
            DontDestroyOnLoad(this);
        }
    }
}
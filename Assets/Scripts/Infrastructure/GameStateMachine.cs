using Scripts.Infrastructure.Services.LoadLevels;
using Scripts.Infrastructure.States;
using Scripts.UI.Common.StateViewers;
using Scripts.Utilities;

namespace Scripts.Infrastructure
{
    public class GameStateMachine
    {
        private readonly IState _gameBootstrap;
        private readonly IState _loadScene;

        public GameStateMachine(IStateViewer loadCurtain, ICoroutineRunner coroutineRunner)
        {
            _gameBootstrap = new GameBootstrapState();
            _loadScene = new LoadLevelState(loadCurtain, new UnityLoadLevelService(coroutineRunner), _gameBootstrap);
        }

        public void Start()
        {
            _loadScene.Enter();
        }
    }
}
using Scripts.Utilities;
using Scripts.UI.Common.StateViewers;

namespace Scripts.Infrastructure
{
    public class Game
    {
        private readonly GameStateMachine _gameStateMachine;

        public Game(IStateViewer loadCurtain, ICoroutineRunner coroutineRunner)
        {
            _gameStateMachine = new GameStateMachine(loadCurtain, coroutineRunner);
        }

        public void Start()
        {
            _gameStateMachine.Start();
        }
        
    }
}
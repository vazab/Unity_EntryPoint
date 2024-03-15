using Scripts.Infrastructure;

namespace Scripts.Infrastructure
{
    public class Game
    {
        private GameStateMachine _gameStateMachine;

        public Game()
        {
            _gameStateMachine = new GameStateMachine();
        }
    }
}
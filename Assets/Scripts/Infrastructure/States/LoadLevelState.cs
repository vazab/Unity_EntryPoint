using Scripts.Infrastructure.Services.LoadLevels;
using Scripts.UI.Common.StateViewers;

namespace Scripts.Infrastructure.States
{
    public class LoadLevelState : IState
    {
        private readonly string _levelName = "Level1";
        private readonly IStateViewer _loadCurtain;
        private readonly ILoadLevelService _loadLevelService;
        private readonly IState _nextState;

        public LoadLevelState(IStateViewer loadCurtain, ILoadLevelService loadLevelService, IState nextState)
        {
            _loadCurtain = loadCurtain;
            _loadLevelService = loadLevelService;
            _nextState = nextState;
        }

        public void Enter()
        {
            _loadLevelService.Load(_levelName, Exit);
            _loadCurtain.Enable();
        }

        public void Exit()
        {
            _nextState.Enter();
            _loadCurtain.Disable();
        }
    }
}
using UnityEngine.SceneManagement;

namespace Scripts.Infrastructure.States
{
    public class LoadSceneState : IState
    {
        private readonly string _sceneNameLevel1 = "Level1";

        public void Enter()
        {
            SceneManager.LoadScene(_sceneNameLevel1);
        }

        public void Exit()
        {

        }
    }
}
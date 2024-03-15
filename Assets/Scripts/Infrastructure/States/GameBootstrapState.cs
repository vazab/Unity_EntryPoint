using UnityEngine;

namespace Scripts.Infrastructure.States
{
    internal class GameBootstrapState : IState
    {
        public void Enter()
        {
            Debug.LogWarning("On GameBootstrapState");
        }

        public void Exit() { }
    }
}
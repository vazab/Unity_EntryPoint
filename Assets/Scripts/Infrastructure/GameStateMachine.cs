﻿using Scripts.Infrastructure.States;

namespace Scripts.Infrastructure
{
    public class GameStateMachine
    {
        private IState _loadScene;

        public GameStateMachine()
        {
            _loadScene = new LoadSceneState();
            _loadScene.Enter();
        }
    }
}
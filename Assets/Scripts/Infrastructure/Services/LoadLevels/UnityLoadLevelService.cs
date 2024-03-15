using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scripts.Utilities;

namespace Scripts.Infrastructure.Services.LoadLevels
{
    public class UnityLoadLevelService : ILoadLevelService
    {
        private readonly ICoroutineRunner _coroutineRunner;

        public UnityLoadLevelService(ICoroutineRunner coroutineRunner)
        {
            _coroutineRunner = coroutineRunner;
        }

        public void Load(string name, Action onLoadLevel)
        {
            _coroutineRunner.StartCoroutine(LoadScene(name, onLoadLevel));
        }

        private IEnumerator LoadScene(string name, Action onLevelLoaded)
        {
            if (SceneManager.GetActiveScene().name == name)
            { 
                onLevelLoaded?.Invoke();
                yield break;
            }

            AsyncOperation waitLoadScene = SceneManager.LoadSceneAsync(name);
            while (waitLoadScene.isDone == false)
            {
                yield return null;
            }

            onLevelLoaded?.Invoke();
        }
    }
}
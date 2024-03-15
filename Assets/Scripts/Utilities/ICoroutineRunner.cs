using System.Collections;
using UnityEngine;

namespace Scripts.Utilities
{
    public interface ICoroutineRunner
    {
        public Coroutine StartCoroutine(IEnumerator loadScene);
    }
}
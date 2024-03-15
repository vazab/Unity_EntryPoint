using UnityEngine;

namespace Scripts.Infrastructure
{
    public class GameBootstrapper : MonoBehaviour
    {
        public void Awake()
        {
            Game game = new Game();
        }
    }
}

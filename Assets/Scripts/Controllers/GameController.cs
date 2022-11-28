using UnityEngine;

namespace Asteroids
{
    public sealed class GameController : MonoBehaviour
    {
        #region Fields
        
        private Controllers _controllers;
        
        #endregion
        
        private void Start()
        {
            _controllers = new Controllers();
            Initialization();
        }

        private void Update()
        {
            for (var i = 0; i < _controllers.Length; i++)
            {
                _controllers[i].Execute();
            }
        }

        private void Initialization()
        {
            _controllers.Init();
        }
    }
}
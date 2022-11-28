using UnityEngine;
using UnityEngine.EventSystems;

namespace Asteroids
{
    public sealed class InputController : IExecute
    {
        #region Fields
        
        private readonly SpaceshipsData _spaceshipsData;
        private Rigidbody _rigidbody;
        
        #endregion

        #region Properties

        private Rigidbody SpaceshipRigidbody => _rigidbody ? _rigidbody : 
            _rigidbody = _spaceshipsData.SpaceshipBehaviour.GetComponent<Rigidbody>();

        #endregion
        public InputController()
        {
            _spaceshipsData = Data.Instance.Spaceship;
        }

        #region Methods

        public void Execute()
        {
            if (!Services.Instance.LoadLevelService.IsLvlLoaded())
            {
                return;
            }
            var  moveHorizontal = Input.GetAxis("Horizontal");
            var moveVertical = Input.GetAxis("Vertical");
            Move(moveHorizontal, moveVertical);
        }

        private void Move(float moveHorizontal, float moveVertical)
        {
            var speed = _spaceshipsData.GetSpeed();
            var point = Services.Instance.CameraService.CameraMain.WorldToViewportPoint(_spaceshipsData
                .SpaceshipBehaviour.transform.position);
            var movement = new Vector3
            {
                y = 0
            };
            
            if ((point.x > 1 && moveHorizontal > 0) || (point.x < 0 && moveHorizontal < 0))
            {
                movement.x = 0;
            }
            else
            {
                movement.x = moveHorizontal;
            }
            
            if ((point.y > 1 && moveVertical > 0) || (point.y < 0 && moveVertical < 0))
            {
                movement.z = 0;
            }
            else
            {
                movement.z = moveVertical;
            }
            
            SpaceshipRigidbody.velocity = movement;
        }

        #endregion
        
    }
}
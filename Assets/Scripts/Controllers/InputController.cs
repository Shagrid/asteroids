using UnityEngine;
using UnityEngine.EventSystems;

namespace Asteroids
{
    public sealed class InputController : IExecute
    {
        #region Fields
        
        private readonly SpaceshipsData _spaceshipsData;
        private Rigidbody _rigidbody;
        private const float minPointPosition = 0.05f;
        private const float maxPointPosition = 0.95f;
        
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
            
            if ((point.x > maxPointPosition && moveHorizontal > 0) || (point.x < minPointPosition && moveHorizontal < 0))
            {
                movement.x = 0;
            }
            else
            {
                movement.x = moveHorizontal * speed;
            }
            
            if ((point.y > maxPointPosition && moveVertical > 0) || (point.y < minPointPosition && moveVertical < 0))
            {
                movement.z = 0;
            }
            else
            {
                movement.z = moveVertical * speed;
            }
            
            SpaceshipRigidbody.velocity = movement;
        }

        #endregion
        
    }
}
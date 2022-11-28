using UnityEngine;

namespace Asteroids
{
    [CreateAssetMenu(fileName = "SpaceshipsData", menuName = "Data/Spaceships/SpaceshipsData")]
    public sealed class SpaceshipsData : ScriptableObject
    {
        #region Fields

        [SerializeField] private float _speed = 50f;
        private SpaceshipBehaviour _spaceshipBehaviour;

        #endregion

        #region Methods

        public void Init(SpaceshipType spaceshipType, Transform point)
        {
            var characterBehaviour = CustomResources.Load<SpaceshipBehaviour>
                (AssetsPathSpaceshipsGameObjects.SpaceshipGameObject[spaceshipType]);
            _spaceshipBehaviour = GameObject.Instantiate(characterBehaviour, point.position, point.rotation);
            
        }

        #endregion
       
    }
}
using UnityEngine;

namespace Asteroids
{
    [CreateAssetMenu(fileName = "SpaceshipsData", menuName = "Data/Spaceships/SpaceshipsData")]
    public sealed class SpaceshipsData : ScriptableObject
    {
        #region Fields

        [SerializeField] private float _speed = 1f;
        private SpaceshipBehaviour _spaceshipBehaviour;

        #endregion

        #region Properties

        [HideInInspector] public SpaceshipBehaviour SpaceshipBehaviour => _spaceshipBehaviour;

        #endregion

        #region Methods

        public void Init(SpaceshipType spaceshipType, Transform point)
        {
            var characterBehaviour = CustomResources.Load<SpaceshipBehaviour>
                (AssetsPathSpaceshipsGameObjects.SpaceshipGameObject[spaceshipType]);
            _spaceshipBehaviour = Instantiate(characterBehaviour, point.position, point.rotation);
            
        }

        public float GetSpeed()
        {
            return _speed;
        }

        #endregion
       
    }
}
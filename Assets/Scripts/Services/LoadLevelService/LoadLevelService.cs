using UnityEngine;

namespace Asteroids
{
    public sealed class LoadLevelService
    {
        #region Fields
        
        private GameObject _currentLevel;
        private GameObject _currentSpaceship;

        #endregion

        #region Methods

        public void LoadLevel(LevelNumbers levelNumber, SpaceshipType spaceship)
        {
            DestroyLevel();
            var lvl = Data.Instance.LevelsData.GetPrefabLevel(levelNumber);
            _currentLevel = GameObject.Instantiate(lvl);
            var camera = _currentLevel.GetComponentInChildren<Camera>();
            Services.Instance.CameraService.SetCamera(camera);
            var spaceshipPosition = GameObject.FindWithTag(TagManager.GetTag(TagType.StartSpaceshipPosition)).transform;
            Data.Instance.Spaceship.Init(spaceship, spaceshipPosition);
            
        }

        private void DestroyLevel()
        {
            if (_currentLevel == null) return;
            GameObject.Destroy(_currentLevel);
        }
        
        public bool IsLvlLoaded()
        {
            return _currentLevel != null;
        }

        #endregion
    }
}
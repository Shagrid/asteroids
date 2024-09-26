using System;
using System.Linq;
using UnityEngine;

namespace Asteroids
{
    [CreateAssetMenu(fileName = "LevelsData", menuName = "Data/Levels/LevelsData")]
    public sealed class LevelsData : ScriptableObject
    {
        [SerializeField] private Level[] _levels;
        
        private Level GetLevelData(LevelNumbers levelNumber)
        {
            var result = _levels.SingleOrDefault(x => x.LevelNumber == levelNumber);
            if (result == null)
                throw new ArgumentException("Нет данных для уровня " + levelNumber);
            return result;
        }
        
        public GameObject GetPrefabLevel(LevelNumbers levelNumber)
        {
          
            return GetLevelData(levelNumber).LocationPrefab;
        }
    }
}
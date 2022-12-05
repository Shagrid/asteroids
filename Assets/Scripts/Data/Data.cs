using System;
using System.IO;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Asteroids
{
    [CreateAssetMenu(fileName = "Data", menuName = "Data/Data")]
    public sealed class Data : ScriptableObject
    {
        #region Fields

        [SerializeField] private string _levelsDataPath;
        [SerializeField] private string _spaceshipDataPath;
        [SerializeField] private string _asteroidsDataPath;
        
        private static LevelsData _levelsData;
        private static SpaceshipsData _spaceshipsData;
        private static AsteroidsData _asteroidsData;
        
        private static readonly Lazy<Data> _instance = new Lazy<Data>(() => Load<Data>("Data/" + typeof(Data).Name));

        #endregion
        
        #region Properties
        
        public static Data Instance => _instance.Value;
        
        public LevelsData LevelsData
        {
            get
            {
                if (_levelsData == null)
                {
                    _levelsData = Load<LevelsData>("Data/" + Instance._levelsDataPath);
                }

                return _levelsData;
            }
        }
        
        public SpaceshipsData Spaceship
        {
            get
            {
                if (_spaceshipsData == null)
                {
                    _spaceshipsData= Load<SpaceshipsData>("Data/" + Instance._spaceshipDataPath);
                }

                return _spaceshipsData;
            }
        }
        
        public AsteroidsData Asteroids
        {
            get
            {
                if (_asteroidsData == null)
                {
                    _asteroidsData = Load<AsteroidsData>("Data/" + Instance._asteroidsDataPath);
                }

                return _asteroidsData;
            }
        }
        
        #endregion
        
        private static T Load<T>(string resourcesPath) where T : Object =>
            CustomResources.Load<T>(Path.ChangeExtension(resourcesPath, null));
    }
}
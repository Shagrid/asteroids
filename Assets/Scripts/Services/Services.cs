using System;

namespace Asteroids
{
    public sealed class Services
    {
        #region Fields

        private static readonly Lazy<Services> _instance = new Lazy<Services>();

        #endregion
        
        #region Properties

        public static Services Instance => _instance.Value;
        public LoadLevelService LoadLevelService { get; private set; }
        public CameraServices CameraServices { get; private set; }

        #endregion
        
        public Services()
        {
            Initialize();
        }

        
        #region Methods
        
        private void Initialize()
        {
            LoadLevelService = new LoadLevelService();
            CameraServices = new CameraServices();
        }
        
        #endregion
        
        
    }
}
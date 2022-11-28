namespace Asteroids
{
    public sealed class Controllers : IInitialization
    {
        #region Fields
        
        private readonly IInitialization[] _initializations;
        private readonly IExecute[] _executeControllers;
        
        #endregion
        
        public int Length => _executeControllers.Length;
        public IExecute this[int index] => _executeControllers[index];
        
        public Controllers()
        {
            _initializations = new IInitialization[1];
            _initializations[0] = new LoadlevelController();
            _executeControllers = new IExecute[0];
        }
        
        public void Init()
        {
            for (var i = 0; i < _initializations.Length; i++)
            {
                var initialization = _initializations[i];
                initialization.Init();
            }
            
            for (var i = 0; i < _executeControllers.Length; i++)
            {
                var execute = _executeControllers[i];
                if (execute is IInitialization initialization)
                {
                    initialization.Init();
                }
            }
        }
    }
}
namespace Asteroids
{
    public sealed class LoadlevelController : IInitialization
    {
        public void Init()
        {
            Services.Instance.LoadLevelService.LoadLevel(LevelNumbers.Level1, SpaceshipType.Spaceship1);
        }
    }
}
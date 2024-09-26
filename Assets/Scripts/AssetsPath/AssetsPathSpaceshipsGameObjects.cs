using System.Collections.Generic;

namespace Asteroids
{
    public sealed class AssetsPathSpaceshipsGameObjects
    {
        public static readonly Dictionary<SpaceshipType, string> SpaceshipGameObject = new Dictionary<SpaceshipType, string>
        {
            {
                SpaceshipType.Spaceship1, "Prefabs/Spaceships/Spaceship1"
            }

        };
    }
}
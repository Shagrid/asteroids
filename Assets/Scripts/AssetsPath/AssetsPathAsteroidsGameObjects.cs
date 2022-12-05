using System;
using System.Collections.Generic;

namespace Asteroids
{
    public sealed class AssetsPathAsteroidsGameObjects
    {
        private static readonly string[] _asteroidsGameObject = new[]
        {
            "Prefabs/Asteroids/Asteroid1"
        };
        
        public static string GetRandomAsteroidAssetPath()
        {
            var rnd = new Random();
            var index = rnd.Next(_asteroidsGameObject.Length);
            return _asteroidsGameObject[index];
        }
    }
}
using System;
using UnityEngine;

namespace Asteroids
{
    [Serializable]
    public sealed class Level
    {
        public LevelNumbers LevelNumber;
        public GameObject LocationPrefab;
    }
}
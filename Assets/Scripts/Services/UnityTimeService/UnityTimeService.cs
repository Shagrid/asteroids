using UnityEngine;

namespace Asteroids
{
    public sealed class UnityTimeService
    {
        public float DeltaTime() => Time.deltaTime;
    }
}
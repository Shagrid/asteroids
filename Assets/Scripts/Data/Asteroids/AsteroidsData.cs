using UnityEngine;

namespace Asteroids
{
    [CreateAssetMenu(fileName = "AsteroidsData", menuName = "Data/Asteroids/AsteroidsData")]
    public sealed class AsteroidsData : ScriptableObject
    {
        [SerializeField] private float _baseSpeed = 1f;
    }
}
using System.Collections.Generic;

namespace Asteroids
{
    public sealed class TagManager
    {
        private static readonly Dictionary<TagType, string> _tags;

        static TagManager()
        {
            _tags = new Dictionary<TagType, string>
            {
                {TagType.StartSpaceshipPosition, "StartSpaceshipPosition"},
            };
        }

        public static string GetTag(TagType tagType)
        {
            return _tags[tagType];
        }
    }
}
using System.Collections;

namespace Butter
{
    public class ClipSequence
    {
        private readonly Clip[] _clips;

        public ClipSequence(params Clip[] clips)
        {
            _clips = clips;
        }

        public IEnumerable PlayAsync()
        {
            foreach (var clip in _clips)
                yield return clip.StartAsync();
        }
    }
}
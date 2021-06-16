using System.Collections;
using UnityEngine;

namespace Butter
{
    public static class ClipExtensions
    {
        public static void Start(this Clip clip)
        {
            var clipRunner = ClipRunnerProvider.GetRunner();
            clipRunner.AddClip(clip);
        }

        public static IEnumerator StartAsync(this Clip clip)
        {
            Start(clip);
            yield return new WaitUntil(() => clip.IsEnded);
        }
    }
}
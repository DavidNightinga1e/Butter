using System;
using Butter;
using NUnit.Framework;

namespace Tests
{
    public class ClipRunnerTests
    {
        [Test]
        public void ClipRunner_sameClipTwice_throwArgumentException()
        {
            var clip = new Clip<float>(Lerpable.ImpreciseFloat, delegate { }, 0, 1, 1f);
            var runner = TestUtilities.GetNewRunner();
            
            Assert.DoesNotThrow(() => runner.AddClip(clip));
            Assert.Throws<ArgumentException>(() => runner.AddClip(clip));
        }
    }
}
using System;
using System.Collections;
using Butter;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Object = UnityEngine.Object;

namespace Tests
{
    public class IntTests
    {
        [Test]
        public void IntRoundNearestLerp_from0to100_doesntBreakStartValue()
        {
            var actual = 0;
            const int startValue = 0;
            const int endValue = 100;

            var lerpable = Lerpable.IntRoundNearest;
            var runner = new GameObject($"ClipRunner-{DateTime.Now.Ticks}").AddComponent<ClipRunner>();
            var clip = new Clip<int>(lerpable, f => actual = f, startValue, endValue, 1f);
            runner.AddClip(clip);

            Assert.AreEqual(startValue, actual);

            Object.Destroy(runner);
        }

        [UnityTest]
        public IEnumerator IntRoundNearestLerp_from0to100_midValueIsNotStartOrEnd()
        {
            var actual = 0;
            const int startValue = 0;
            const int endValue = 100;

            var lerpable = Lerpable.IntRoundNearest;
            var runner = new GameObject($"ClipRunner-{DateTime.Now.Ticks}").AddComponent<ClipRunner>();
            var clip = new Clip<int>(lerpable, f => actual = f, startValue, endValue, 1f);
            runner.AddClip(clip);

            yield return new WaitForSeconds(0.5f);

            Assert.Greater(actual, startValue);
            Assert.Less(actual, endValue);

            Object.Destroy(runner);
        }

        [UnityTest]
        public IEnumerator IntRoundNearestLerp_from0to100_doesntBreakEndValue()
        {
            var actual = 0;
            const int startValue = 0;
            const int endValue = 100;

            var lerpable = Lerpable.IntRoundNearest;
            var runner = new GameObject($"ClipRunner-{DateTime.Now.Ticks}").AddComponent<ClipRunner>();
            var clip = new Clip<int>(lerpable, f => actual = f, startValue, endValue, 1f);
            runner.AddClip(clip);

            yield return new WaitForSeconds(1f);

            Assert.AreEqual(endValue, actual);

            Object.Destroy(runner);
        }
        
        [Test]
        public void IntFloorLerp_from0to100_doesntBreakStartValue()
        {
            var actual = 0;
            const int startValue = 0;
            const int endValue = 100;

            var lerpable = Lerpable.IntFloor;
            var runner = new GameObject($"ClipRunner-{DateTime.Now.Ticks}").AddComponent<ClipRunner>();
            var clip = new Clip<int>(lerpable, f => actual = f, startValue, endValue, 1f);
            runner.AddClip(clip);

            Assert.AreEqual(startValue, actual);

            Object.Destroy(runner);
        }

        [UnityTest]
        public IEnumerator IntFloorLerp_from0to100_midValueIsNotStartOrEnd()
        {
            var actual = 0;
            const int startValue = 0;
            const int endValue = 100;

            var lerpable = Lerpable.IntFloor;
            var runner = new GameObject($"ClipRunner-{DateTime.Now.Ticks}").AddComponent<ClipRunner>();
            var clip = new Clip<int>(lerpable, f => actual = f, startValue, endValue, 1f);
            runner.AddClip(clip);

            yield return new WaitForSeconds(0.5f);

            Assert.Greater(actual, startValue);
            Assert.Less(actual, endValue);

            Object.Destroy(runner);
        }

        [UnityTest]
        public IEnumerator IntFloorLerp_from0to100_doesntBreakEndValue()
        {
            var actual = 0;
            const int startValue = 0;
            const int endValue = 100;

            var lerpable = Lerpable.IntFloor;
            var runner = new GameObject($"ClipRunner-{DateTime.Now.Ticks}").AddComponent<ClipRunner>();
            var clip = new Clip<int>(lerpable, f => actual = f, startValue, endValue, 1f);
            runner.AddClip(clip);

            yield return new WaitForSeconds(1f);

            Assert.AreEqual(endValue, actual);

            Object.Destroy(runner);
        }
    }
}
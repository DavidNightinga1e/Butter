using System;
using System.Collections;
using Butter;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Object = UnityEngine.Object;

namespace Tests
{
    public class FloatTests
    {
        [Test]
        public void PreciseFloatLerp_from0to100_doesntBreakStartValue()
        {
            var actual = 0f;
            const float startValue = 0f;
            const float endValue = 100f;

            var lerpable = Lerpable.PreciseFloat;
            var runner = new GameObject($"ClipRunner-{DateTime.Now.Ticks}").AddComponent<ClipRunner>();
            var clip = new Clip<float>(lerpable, f => actual = f, startValue, endValue, 1f);
            runner.AddClip(clip);

            Assert.AreEqual(startValue, actual);

            Object.Destroy(runner);
        }

        [UnityTest]
        public IEnumerator PreciseFloatLerp_from0to100_midValueIsNotStartOrEnd()
        {
            var actual = 0f;
            const float startValue = 0f;
            const float endValue = 100f;

            var lerpable = Lerpable.PreciseFloat;
            var runner = new GameObject($"ClipRunner-{DateTime.Now.Ticks}").AddComponent<ClipRunner>();
            var clip = new Clip<float>(lerpable, f => actual = f, startValue, endValue, 1f);
            runner.AddClip(clip);

            yield return new WaitForSeconds(0.5f);

            Assert.Greater(actual, startValue);
            Assert.Less(actual, endValue);

            Object.Destroy(runner);
        }

        [UnityTest]
        public IEnumerator PreciseFloatLerp_from0to100_doesntBreakEndValue()
        {
            var actual = 0f;
            const float startValue = 0f;
            const float endValue = 100f;

            var lerpable = Lerpable.PreciseFloat;
            var runner = new GameObject($"ClipRunner-{DateTime.Now.Ticks}").AddComponent<ClipRunner>();
            var clip = new Clip<float>(lerpable, f => actual = f, startValue, endValue, 1f);
            runner.AddClip(clip);

            yield return new WaitForSeconds(1f);

            Assert.AreEqual(endValue, actual);

            Object.Destroy(runner);
        }
        
        [Test]
        public void ImpreciseFloatLerp_from0to100_doesntBreakStartValue()
        {
            var actual = 0f;
            const float startValue = 0f;
            const float endValue = 100f;

            var lerpable = Lerpable.ImpreciseFloat;
            var runner = new GameObject($"ClipRunner-{DateTime.Now.Ticks}").AddComponent<ClipRunner>();
            var clip = new Clip<float>(lerpable, f => actual = f, startValue, endValue, 1f);
            runner.AddClip(clip);

            Assert.AreEqual(startValue, actual);

            Object.Destroy(runner);
        }

        [UnityTest]
        public IEnumerator ImpreciseFloatLerp_from0to100_midValueIsNotStartOrEnd()
        {
            var actual = 0f;
            const float startValue = 0f;
            const float endValue = 100f;

            var lerpable = Lerpable.ImpreciseFloat;
            var runner = new GameObject($"ClipRunner-{DateTime.Now.Ticks}").AddComponent<ClipRunner>();
            var clip = new Clip<float>(lerpable, f => actual = f, startValue, endValue, 1f);
            runner.AddClip(clip);

            yield return new WaitForSeconds(0.5f);

            Assert.Greater(actual, startValue);
            Assert.Less(actual, endValue);

            Object.Destroy(runner);
        }

        [UnityTest]
        public IEnumerator ImpreciseFloatLerp_from0to100_doesntBreakEndValue()
        {
            var actual = 0f;
            const float startValue = 0f;
            const float endValue = 100f;

            var lerpable = Lerpable.ImpreciseFloat;
            var runner = new GameObject($"ClipRunner-{DateTime.Now.Ticks}").AddComponent<ClipRunner>();
            var clip = new Clip<float>(lerpable, f => actual = f, startValue, endValue, 1f);
            runner.AddClip(clip);

            yield return new WaitForSeconds(1f);

            Assert.AreEqual(endValue, actual);

            Object.Destroy(runner);
        }
    }
}
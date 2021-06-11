﻿using System;
using UnityEngine;

namespace Butter
{
    public static class ButterExtensions
    {
        public static void LerpForSeconds(this float targetValue, float to, float time, Action<float> resultProvider)
        {
            var clipRunner = ClipRunnerProvider.GetRunner();
            var clip = new Clip<float>(
                Lerpable.ImpreciseFloat,
                resultProvider.Invoke,
                targetValue,
                to,
                time);
            clipRunner.AddClip(clip);
        }

        public static void LerpForSeconds(this Vector3 targetValue, Vector3 to, float time,
            Action<Vector3> resultProvider)
        {
            var clipRunner = ClipRunnerProvider.GetRunner();
            var clip = new Clip<Vector3>(
                Lerpable.Vector3Imprecise,
                resultProvider.Invoke,
                targetValue,
                to,
                time);
            clipRunner.AddClip(clip);
        }
    }
}
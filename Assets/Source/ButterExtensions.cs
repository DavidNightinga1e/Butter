using System;
using UnityEngine;

namespace Butter
{
    public static class ButterExtensions
    {
        public static Clip<float> LerpForSeconds(this float targetValue, float to, float time,
            Action<float> resultProvider)
        {
            return new Clip<float>(
                Lerper.ImpreciseFloat,
                resultProvider.Invoke,
                targetValue,
                to,
                time);
        }

        public static Clip<Vector3> LerpForSeconds(this Vector3 targetValue, Vector3 to, float time,
            Action<Vector3> resultProvider)
        {
            return new Clip<Vector3>(
                Lerper.Vector3Imprecise,
                resultProvider.Invoke,
                targetValue,
                to,
                time);
        }

        public static Clip<Color> LerpForSeconds(this Color targetValue, Color to, float time,
            Action<Color> resultProvider)
        {
            return new Clip<Color>(
                Lerper.ColorRgbImprecise,
                resultProvider.Invoke,
                targetValue,
                to,
                time);
        }

        public static Clip<Vector3> LerpPositionForSeconds(this Transform targetValue, Vector3 targetPosition,
            float time)
        {
            return new Clip<Vector3>(
                Lerper.Vector3Imprecise,
                value =>
                {
                    if (targetValue)
                        targetValue.position = value;
                    else
                        throw new ArgumentException($"{nameof(targetValue)} was destroyed while preforming lerp");
                },
                targetValue.position,
                targetPosition,
                time);
        }

        public static Clip<Color> LerpForSeconds(this Color targetValue, Color from, Color to, float time,
            Action<Color> resultProvider)
        {
            resultProvider.Invoke(from);
            return new Clip<Color>(
                Lerper.ColorRgbImprecise,
                resultProvider.Invoke,
                targetValue,
                to,
                time);
        }

        public static Clip<Vector3> LerpPositionForSeconds(this Transform targetValue, Vector3 fromPosition,
            Vector3 toPosition,
            float time)
        {
            targetValue.position = fromPosition;
            return new Clip<Vector3>(
                Lerper.Vector3Imprecise,
                value =>
                {
                    if (targetValue)
                        targetValue.position = value;
                    else
                        throw new ArgumentException($"{nameof(targetValue)} was destroyed while preforming lerp");
                },
                targetValue.position,
                toPosition,
                time);
        }

        public static Clip<Vector3> LerpRotationForSeconds(this Transform targetValue, Vector3 targetPosition,
            float time)
        {
            return new Clip<Vector3>(
                Lerper.Vector3Imprecise,
                value =>
                {
                    if (targetValue)
                        targetValue.position = value;
                    else
                        throw new ArgumentException($"{nameof(targetValue)} was destroyed while preforming lerp");
                },
                targetValue.position,
                targetPosition,
                time);
        }
    }
}
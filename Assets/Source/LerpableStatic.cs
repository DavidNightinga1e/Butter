using UnityEngine;

namespace Butter
{
    public static class Lerper
    {
        public static readonly Lerper<float> ImpreciseFloat =
            new Lerper<float>((minValue, maxValue, t) => minValue + t * (maxValue - minValue));

        public static readonly Lerper<float> PreciseFloat =
            new Lerper<float>((minValue, maxValue, t) => (1 - t) * minValue + t * maxValue);

        public static readonly Lerper<int> IntRoundNearest =
            new Lerper<int>((minValue, maxValue, t) => minValue + Mathf.RoundToInt(t * (maxValue - minValue)));

        public static readonly Lerper<int> IntFloor =
            new Lerper<int>((minValue, maxValue, t) => minValue + Mathf.FloorToInt(t * (maxValue - minValue)));

        public static readonly Lerper<int> IntCeil =
            new Lerper<int>((minValue, maxValue, t) => minValue + Mathf.CeilToInt(t * (maxValue - minValue)));

        public static readonly Lerper<Vector3> Vector3Imprecise =
            new Lerper<Vector3>((minValue, maxValue, t)
                => new Vector3(
                    ImpreciseFloat.Evaluate(minValue.x, maxValue.x, t),
                    ImpreciseFloat.Evaluate(minValue.y, maxValue.y, t),
                    ImpreciseFloat.Evaluate(minValue.z, maxValue.z, t)));

        public static readonly Lerper<Vector3> Vector3Precise =
            new Lerper<Vector3>((minValue, maxValue, t)
                => new Vector3(
                    PreciseFloat.Evaluate(minValue.x, maxValue.x, t),
                    PreciseFloat.Evaluate(minValue.y, maxValue.y, t),
                    PreciseFloat.Evaluate(minValue.z, maxValue.z, t)));

        public static readonly Lerper<Quaternion> Quaternion = new Lerper<Quaternion>(UnityEngine.Quaternion.Lerp);

        public static readonly Lerper<Quaternion> QuaternionSpherical =
            new Lerper<Quaternion>(UnityEngine.Quaternion.Slerp);

        public static readonly Lerper<Vector2> Vector2Imprecise =
            new Lerper<Vector2>((minValue, maxValue, t)
                => new Vector2(
                    ImpreciseFloat.Evaluate(minValue.x, maxValue.x, t),
                    ImpreciseFloat.Evaluate(minValue.y, maxValue.y, t)));

        public static readonly Lerper<Vector2> Vector2Precise =
            new Lerper<Vector2>((minValue, maxValue, t)
                => new Vector3(
                    PreciseFloat.Evaluate(minValue.x, maxValue.x, t),
                    PreciseFloat.Evaluate(minValue.y, maxValue.y, t)));

        public static readonly Lerper<Color> ColorRgbImprecise =
            new Lerper<Color>((minValue, maxValue, t)
                => new Color(
                    ImpreciseFloat.Evaluate(minValue.r, maxValue.r, t),
                    ImpreciseFloat.Evaluate(minValue.g, maxValue.g, t),
                    ImpreciseFloat.Evaluate(minValue.b, maxValue.b, t)));
    }
}
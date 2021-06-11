using UnityEngine;

namespace Butter
{
    public static class Lerpable
    {
        public static readonly Lerpable<float> ImpreciseFloat =
            new Lerpable<float>((minValue, maxValue, t) => minValue + t * (maxValue - minValue));

        public static readonly Lerpable<float> PreciseFloat =
            new Lerpable<float>((minValue, maxValue, t) => (1 - t) * minValue + t * maxValue);

        public static readonly Lerpable<int> IntRoundNearest =
            new Lerpable<int>((minValue, maxValue, t) => minValue + Mathf.RoundToInt(t * (maxValue - minValue)));

        public static readonly Lerpable<int> IntFloor =
            new Lerpable<int>((minValue, maxValue, t) => minValue + Mathf.FloorToInt(t * (maxValue - minValue)));

        public static readonly Lerpable<int> IntCeil =
            new Lerpable<int>((minValue, maxValue, t) => minValue + Mathf.CeilToInt(t * (maxValue - minValue)));

        public static readonly Lerpable<Vector3> Vector3Imprecise =
            new Lerpable<Vector3>((minValue, maxValue, t)
                => new Vector3(
                    ImpreciseFloat.Evaluate(minValue.x, maxValue.x, t),
                    ImpreciseFloat.Evaluate(minValue.y, maxValue.y, t),
                    ImpreciseFloat.Evaluate(minValue.z, maxValue.z, t)));

        public static readonly Lerpable<Vector3> Vector3Precise =
            new Lerpable<Vector3>((minValue, maxValue, t)
                => new Vector3(
                    PreciseFloat.Evaluate(minValue.x, maxValue.x, t),
                    PreciseFloat.Evaluate(minValue.y, maxValue.y, t),
                    PreciseFloat.Evaluate(minValue.z, maxValue.z, t)));

        public static readonly Lerpable<Vector2> Vector2Imprecise =
            new Lerpable<Vector2>((minValue, maxValue, t)
                => new Vector2(
                    ImpreciseFloat.Evaluate(minValue.x, maxValue.x, t),
                    ImpreciseFloat.Evaluate(minValue.y, maxValue.y, t)));

        public static readonly Lerpable<Vector2> Vector2Precise =
            new Lerpable<Vector2>((minValue, maxValue, t)
                => new Vector3(
                    PreciseFloat.Evaluate(minValue.x, maxValue.x, t),
                    PreciseFloat.Evaluate(minValue.y, maxValue.y, t)));
    }
}
namespace Butter
{
    /// <summary>
    /// Immutable type that gives you ability to make anything Lerpable, for Butter to understand how to work with it 
    /// </summary>
    /// <typeparam name="T">Type that we work with</typeparam>
    public class Lerpable<T>
    {
        private readonly Lerp _lerpFunction;

        public delegate T Lerp(T minValue, T maxValue, float t);

        public Lerpable(Lerp lerpFunction) => _lerpFunction = lerpFunction;

        public T Evaluate(T from, T to, float t) => _lerpFunction.Invoke(from, to, t);
    }
}
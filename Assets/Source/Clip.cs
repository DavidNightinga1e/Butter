namespace Butter
{
    public class Clip<T> : Clip
    {
        private readonly T _startValue;
        private readonly T _endValue;
        private readonly Set _setter;
        private readonly Lerper<T> _lerper;

        public delegate void Set(T value);

        public Clip(Lerper<T> lerper, Set set, T startValue, T endValue, float timeLength) : base(timeLength)
        {
            _lerper = lerper;
            _setter = set;
            _startValue = startValue;
            _endValue = endValue;
        }

        protected override void Calculate()
        {
            var newValue = _lerper.Evaluate(_startValue, _endValue, CurrentTimeNormalized);
            _setter.Invoke(newValue);
        }
    }
}
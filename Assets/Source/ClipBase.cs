using System;

namespace Butter
{
    public abstract class Clip
    {
        private readonly float _timeLength;

        private float _currentTime;
        protected float CurrentTimeNormalized => _currentTime / _timeLength;
        public bool IsEnded { get; protected set; }

        public void AddDelta(float delta)
        {
            if (delta < 0)
                throw new ArgumentException("Delta cannot be negative");
            _currentTime += delta;
            if (_currentTime >= _timeLength)
            {
                _currentTime = _timeLength;
                IsEnded = true;
            }

            Calculate();
        }

        protected abstract void Calculate();

        protected Clip(float timeLength)
        {
            _timeLength = timeLength;
        }
    }
}
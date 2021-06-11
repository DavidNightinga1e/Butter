﻿using System;

namespace Butter
{
    public class Clip<T> : IClip
    {
        private readonly T _startValue;
        private readonly T _endValue;
        private readonly Set _setter;
        private readonly Lerpable<T> _lerpable;
        private readonly float _timeLength;

        private float _currentTime;

        private float CurrentTimeNormalized => _currentTime / _timeLength;

        public bool IsEnded { get; private set; }

        public delegate void Set(T value);

        public Clip(Lerpable<T> lerpable, Set set, T startValue, T endValue, float timeLength)
        {
            _lerpable = lerpable;
            _setter = set;
            _startValue = startValue;
            _endValue = endValue;
            _timeLength = timeLength;
        }

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

        private void Calculate()
        {
            var newValue = _lerpable.Evaluate(_startValue, _endValue, CurrentTimeNormalized);
            _setter.Invoke(newValue);
        }
    }
}
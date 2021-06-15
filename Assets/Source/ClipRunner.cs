using System;
using System.Collections.Generic;
using UnityEngine;

namespace Butter
{
    public class ClipRunner : MonoBehaviour
    {
        private readonly List<Clip> _clips = new List<Clip>();

        public void AddClip(Clip clip)
        {
            if (_clips.Contains(clip))
                throw new ArgumentException($"Was trying to insert same instance of a clip in same runner");
            _clips.Add(clip);
        }

        private void Update()
        {
            var deltaTime = Time.deltaTime;

            foreach (var clip in _clips)
                clip.AddDelta(deltaTime);

            _clips.RemoveAll(t => t.IsEnded);
        }
    }
}
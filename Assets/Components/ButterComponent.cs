﻿using UnityEngine;

namespace Butter.Components
{
    public abstract class ButterComponent : MonoBehaviour
    {
        public ComponentAutoPlay componentAutoPlay;

        protected virtual void OnEnable()
        {
            if (componentAutoPlay.HasFlag(ComponentAutoPlay.OnEnable))
                Play();
        }
        
        protected virtual void Awake()
        {
            if (componentAutoPlay.HasFlag(ComponentAutoPlay.OnAwake))
                Play();
        }

        protected virtual void Start()
        {
            if (componentAutoPlay.HasFlag(ComponentAutoPlay.OnStart))
                Play();
        }
        
        public abstract void Play();
    }
}
using System;

namespace Butter.Components
{
    [Flags]
    public enum ComponentAutoPlay
    {
        OnEnable,
        OnAwake,
        OnStart
    }
}
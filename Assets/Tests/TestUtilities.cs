using System;
using Butter;
using UnityEngine;

namespace Tests
{
    public static class TestUtilities
    {
        public static ClipRunner GetNewRunner() =>
            new GameObject($"ClipRunner-{DateTime.Now.Ticks}").AddComponent<ClipRunner>();
    }
}
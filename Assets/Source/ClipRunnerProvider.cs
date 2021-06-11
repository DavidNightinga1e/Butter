using UnityEngine;

namespace Butter
{
    public static class ClipRunnerProvider
    {
        private const string DefaultName = "ButterClipRunner";
        
        private static ClipRunner _cachedInstance;

        public static ClipRunner GetRunner()
        {
            if (_cachedInstance)
                return _cachedInstance;

            var foundInstance = Object.FindObjectOfType<ClipRunner>();
            _cachedInstance = foundInstance
                ? foundInstance
                : GetNewRunner();

            return _cachedInstance;
        }

        private static ClipRunner GetNewRunner()
        {
            var instance = new GameObject(DefaultName);
            var clipRunner = instance.AddComponent<ClipRunner>();
            return clipRunner;
        }
    }
}
using System.Collections;
using UnityEngine;

namespace Butter.Components
{
    public class ButterLerpColor : ButterComponent
    {
        public Renderer targetRenderer;

        public Color startColor;
        public Color endColor;

        private Material _targetMaterial;

        public override void Play()
        {
            _targetMaterial = new Material(targetRenderer.material) {color = startColor};
            targetRenderer.material = _targetMaterial;
            _targetMaterial.color.LerpForSeconds(endColor, length, color => _targetMaterial.color = color);
        }

        public override IEnumerable PlayAsync()
        {
            Play();
            yield return new WaitForSeconds(length);
        }
    }
}
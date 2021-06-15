using UnityEngine;

namespace Butter.Components
{
    public class ButterLerpColor : ButterComponent
    {
        public Renderer targetRenderer;

        public Color startColor;
        public Color endColor;
        public float timeToChangeColor;

        private Material _targetMaterial;

        public override void Play()
        {
            _targetMaterial = new Material(targetRenderer.material) {color = startColor};
            targetRenderer.material = _targetMaterial;
            _targetMaterial.color.LerpForSeconds(endColor, timeToChangeColor, color => _targetMaterial.color = color);
        }
    }
}
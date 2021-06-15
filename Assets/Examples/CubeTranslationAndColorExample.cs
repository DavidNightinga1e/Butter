using System.Collections;
using Butter;
using UnityEngine;

namespace Examples
{
    public class CubeTranslationAndColorExample : MonoBehaviour
    {
        public Transform targetTransform;
        public Renderer targetRenderer;

        public Vector3 from;
        public Vector3 to;
        public Color fromColor;
        public Color toColor;

        public float timeLength;


        IEnumerator Start()
        {
            var positionForward = targetTransform.LerpPositionForSeconds(@from, to, timeLength);
            var positionBackward = targetTransform.LerpPositionForSeconds(to, from, timeLength);
            targetRenderer.material = new Material(targetRenderer.material);
            var colorForward = targetRenderer.material.color.LerpForSeconds(fromColor, toColor, timeLength,
                color => targetRenderer.material.color = color);
            var colorBackward = targetRenderer.material.color.LerpForSeconds(toColor, fromColor, timeLength,
                color => targetRenderer.material.color = color);

            var positionsSequence = new ClipSequence(positionForward, positionBackward);
            var colorSequence = new ClipSequence(colorForward, colorBackward);
        }
    }
}
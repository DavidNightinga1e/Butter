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
            targetRenderer.material = new Material(targetRenderer.material);

            var forward = new Clip<(Color, Vector3)>(new Lerper<(Color, Vector3)>(LerpFunction), tuple =>
            {
                targetRenderer.material.color = tuple.Item1;
                targetTransform.position = tuple.Item2;
            }, (fromColor, @from), (toColor, to), timeLength);

            yield return forward.StartAsync();
        }

        private (Color, Vector3) LerpFunction((Color, Vector3) minvalue, (Color, Vector3) maxvalue, float t)
        {
            return (Lerper.ColorRgbImprecise.Evaluate(minvalue.Item1, maxvalue.Item1, t),
                Lerper.Vector3Imprecise.Evaluate(minvalue.Item2, maxvalue.Item2, t));
        }
    }
}
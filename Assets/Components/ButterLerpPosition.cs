using System.Collections;
using UnityEngine;

namespace Butter.Components
{
    public class ButterLerpPosition : ButterComponent
    {
        public Transform targetTransform;

        public Vector3 startPosition;
        public Vector3 endPosition;

        public override void Play()
        {
            targetTransform.position = startPosition;
            targetTransform.LerpPositionForSeconds(endPosition, length);
        }

        public override IEnumerable PlayAsync()
        {
            Play();
            yield return new WaitForSeconds(length);
        }
    }
}
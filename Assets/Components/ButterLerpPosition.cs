using UnityEngine;

namespace Butter.Components
{
    public class ButterLerpPosition : ButterComponent
    {
        public Transform targetTransform;

        public Vector3 startPosition;
        public Vector3 endPosition;
        public float timeToMove;

        public override void Play()
        {
            targetTransform.position = startPosition;
            targetTransform.position.LerpForSeconds(
                endPosition,
                timeToMove,
                vector3 => targetTransform.position = vector3);
        }
    }
}
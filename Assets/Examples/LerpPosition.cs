using System;
using UnityEngine;

namespace Butter.Examples
{
    public class LerpPosition : MonoBehaviour
    {
        public Transform targetTransform;

        public Vector3 startPosition;
        public Vector3 endPosition;
        public float timeToMove;

        private void Awake()
        {
            targetTransform.position = startPosition;
            targetTransform.position.LerpForSeconds(
                endPosition,
                timeToMove,
                vector3 => targetTransform.position = vector3);
        }
    }
}
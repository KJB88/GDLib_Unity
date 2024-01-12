using UnityEngine;

namespace KBGDLib
{
    public static class SpatialHelper
    {
        public static Transform FindClosestTransform(Transform originTransform, List<Transform> otherEntities)
        {
            Transform transf = default;
            float closestDistance = Mathf.Infinity;
            foreach (Transform t in otherEntities)
            {
                float currentDist = Vector3.Distance(originTransform.position, t.position);
                if (currentDist < closestDistance)
                {
                    closestDistance = currentDist;
                    transf = t;
                }
            }

            return transf;
        }
    }
}

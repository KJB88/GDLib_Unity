using UnityEngine;

namespace KBGDLib.Helpers
{
    public static class MathHelper
    {
        public static Vector2 GetRandomPointInsideTorus(Vector2 origin, float minRadius, float maxRadius)
        {
            var randomDirection = Random.insideUnitCircle.normalized;
            var randomDistance = Random.Range(minRadius, maxRadius);
            var point = origin + (randomDirection * randomDistance);

            return point;
        }
    }
}

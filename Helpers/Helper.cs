using UnityEngine;

namespace GDLib.Helpers
{
    public static class Helper
    {
        public static Quaternion LookRotation2D(Vector3 forward)
    => Quaternion.LookRotation(forward, Vector3.right);

    }
}
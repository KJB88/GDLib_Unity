using UnityEngine;
using System.Collections.Generic;

namespace GDLib.Pooling
{
    /// <summary>
    /// Pools <see cref="GameObject"/>s within its collection.
    /// </summary>
    public class GameObjectPool : MonoBehaviour
    {
        [SerializeField]  List<Pool> pools = new List<Pool>();

        private void Start()
        {
            foreach (var pool in pools)
                pool.InitializePool();
        }

        /// <summary>
        /// Gets a <see cref="GameObject"/> out of the target <see cref="Pool"/>, specified by <paramref name="poolName"/>. The <paramref name="pooledObject"/> is assigned to the <see langword="out"/> parameter.
        /// </summary>
        /// <param name="poolName"> is the <see langword="string"/> that identifies the target <see cref="Pool"/>.</param>
        /// <param name="pooledObject"> is the <see langword="out"/> <see cref="GameObject"/> reference to assign the desired <see cref="GameObject"/> to if it is found.</param>
        /// <returns><see langword="true"/> if the target <see cref="Pool"/> is found and it contains available <see cref="GameObject"/>s; otherwise, <see cref="false"/></returns>
        public bool GetPooledObject(string poolName, out GameObject pooledObject)
        {
            poolName = poolName.ToLower();
            pooledObject = null;

            foreach (Pool pool in pools)
            {
                if (pool.PoolName() != poolName) continue;
                if (pool.GetPooledObject(out pooledObject)) return true;
            }

            return false;
        }

        /// <summary>
        /// Places the <see cref="GameObject"/> back into the <see cref="Pool"/> identified by the <paramref name="poolName"/>.
        /// </summary>
        /// <param name="poolName"> the <see langword="string"/> that identifies the target <see cref="Pool"/>.</param>
        /// <param name="returningObj"> the <see cref="GameObject"/> to be returned to the  <see cref="Pool"/>.</param>
        public void ReturnObjectToPool(string poolName, GameObject returningObj)
        {
            foreach (Pool pool in pools)
            {
                if (pool.PoolName() != poolName) continue;

                pool.AddObjectToPool(returningObj);
                break;
            }
        }
    }
}
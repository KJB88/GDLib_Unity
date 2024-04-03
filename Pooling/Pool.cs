using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
public class Pool
{
    [SerializeField] PoolData? poolableData;
    readonly List<GameObject> pooledObjects = new List<GameObject>();

    public string PoolName() => poolableData.PoolableObjectName;
    public int PoolCount() => pooledObjects.Count;
    public bool isPoolEmpty() => PoolCount() == 0;

    public void InitializePool() 
        => PopulatePool(poolableData.InitialPoolSize);

    public void AddObjectToPool(GameObject go)
    {
        go.SetActive(false);
        pooledObjects.Add(go);
    }

    public bool GetPooledObject(out GameObject? obj)
    {
        obj = null;

        if (isPoolEmpty())
        {
            if (!poolableData.CanRepopulate) return false;
            PopulatePool(poolableData.RepopulateSize);
        }

        obj = pooledObjects.Last();
        pooledObjects.Remove(obj);

        return true;
    }

    private void PopulatePool(int maxNew)
    {
        for (int i = 0; i < maxNew; i++)
        {
            GameObject go = GameObject.Instantiate(poolableData.PooledPrefab);
            go.SetActive(false);

            pooledObjects.Add(go);
        }
    }
}
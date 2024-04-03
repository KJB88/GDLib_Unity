using UnityEngine;

[CreateAssetMenu(fileName = "PoolData", menuName = "Custom/PoolData", order = 2)]
public class PoolData : ScriptableObject
{
    [Header("Object Data")]
    [SerializeField] private string poolableObjectName = "";
    [SerializeField] private GameObject? pooledPrefab;
    public string PoolableObjectName => poolableObjectName.ToLower();
    public GameObject PooledPrefab => pooledPrefab;

    [Header("Pool Data")]
    [SerializeField] private int initialPoolSize;
    [SerializeField] bool canRepopulate;
    [SerializeField] private int repopulateSize;
    public int InitialPoolSize => initialPoolSize;
    public bool CanRepopulate => canRepopulate;
    public int RepopulateSize => repopulateSize;
}
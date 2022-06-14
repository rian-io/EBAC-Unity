using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooler : MonoBehaviour
{
    #region Serializable Fields
    [SerializeField] private GameObject _objectToPool;
    [SerializeField] private int _amountToPool;
    #endregion

    #region Private Fields
    private List<GameObject> _pooledObjects;

    public static Pooler s_sharedInstance;
    #endregion
    
    #region Unity Methods
    private void Awake()
    {
        s_sharedInstance = this;
    }

    // Start is called before the first frame update
    private void Start()
    {
        _pooledObjects = new List<GameObject>();
        for (int i = 0; i < _amountToPool; i++)
        {
            GameObject obj = (GameObject)Instantiate(_objectToPool);
            obj.SetActive(false);
            _pooledObjects.Add(obj);
            obj.transform.SetParent(this.transform);
        }
    }
    #endregion

    #region Private Methods
    private Pooler() { }
    #endregion

    #region Public Methods
    public GameObject GetPooledObject()
    {
        for (int i = 0; i < _pooledObjects.Count; i++)
        {
            if (!_pooledObjects[i].activeInHierarchy)
            {
                return _pooledObjects[i];
            }
        }
        return null;
    }
    #endregion
}

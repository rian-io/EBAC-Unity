using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    #region Serializable Fields
    [SerializeField] private float _dynamicRange = 4.0f;
    #endregion

    #region Private Fields
    private Vector3 _initialPos = new Vector3(0, 1, 0);
    #endregion

    #region Unity Methods
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Get an object object from the pool
            GameObject pooledProjectile = Pooler.s_sharedInstance.GetPooledObject();
            if (pooledProjectile != null)
            {
                pooledProjectile.SetActive(true); // activate it

                float x = Random.Range(-_dynamicRange, _dynamicRange);
                float z = Random.Range(-_dynamicRange, _dynamicRange);
                Vector3 spawnPosition = _initialPos + new Vector3(x, 0, z);

                pooledProjectile.transform.position = spawnPosition;
            }
        }
    }
    #endregion
}

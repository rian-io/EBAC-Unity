using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimeManager : MonoBehaviour
{
    #region Serializable Fields
    [SerializeField] private float _lifeTime;
    #endregion

    #region Unity Methods
    private void OnEnable() {
        StartCoroutine(LifeTime());
    }
    #endregion

    #region Coroutines
    IEnumerator LifeTime() {
        yield return new WaitForSeconds(_lifeTime);
        gameObject.SetActive(false);
        
        // Reset velocidade para não iniciar super rápido no próximo uso
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
    #endregion
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    #region Serializable Fields
    [SerializeField] private EnemyData _settings;
    #endregion

    #region Protected Fields
    protected float Speed = 1.0f;
    #endregion

    #region Unity Methods
    private void Awake() {
        Speed = CalculateSpeed();
    }

    private void Start() {
        _settings?.SetLife();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            _settings?.Move(Speed);
        }
    }
    #endregion

    #region Protected Methods
    protected virtual float CalculateSpeed() 
    {
        return Speed + Speed; // apenas para exemplificar o uso de um método virtual sobescrevendo o método da classe base
    }
    #endregion
}

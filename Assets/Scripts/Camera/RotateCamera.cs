using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    #region Serializable Fields
    [SerializeField] private float _speed = 10.0f;
    #endregion

    #region Unity Methods
    private void Update()
    {
        float input = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up, input * _speed * Time.deltaTime);
    }
    #endregion
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AKey : MonoBehaviour
{
    #region Serializable Fields
    [Header("String")]
    [SerializeField] private string _sPressed = "";

    [Header("Float")]
    [SerializeField] private float _fPressed = 0.0f;

    [Header("Integer")]
    [SerializeField] private int _iPressed = 0;
    #endregion

    #region Unity Methods
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _sPressed = "Pressed";
            _fPressed = Time.time;

            Debug.Log(_sPressed);
            Debug.Log(_fPressed);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            _sPressed = "Not Pressed";
            _iPressed++;

            Debug.Log(_sPressed);
            Debug.Log(_iPressed);
        }
    }
    #endregion
}

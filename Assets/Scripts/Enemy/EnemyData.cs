using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnemyData : ScriptableObject
{
    #region Serializable Fields
    [SerializeField] private int _life = 0;
    #endregion

    #region Public Methods
    public void Move(float speed)
    {
        Debug.Log("Moving at " + speed);
    }

    public void SetLife()
    {
        Debug.Log("Life is " + _life);
    }
    #endregion
}

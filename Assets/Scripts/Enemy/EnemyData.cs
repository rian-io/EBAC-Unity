using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnemyData : ScriptableObject
{
    [SerializeField] private int life = 0;

    public void Move(float speed)
    {
        Debug.Log("Moving at " + speed);
    }

    public void SetLife()
    {
        Debug.Log("Life is " + life);
    }
}

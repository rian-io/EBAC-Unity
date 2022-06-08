using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    [SerializeField] private EnemyData settings;

    protected float speed = 1.0f;

    private void Awake() {
        speed = CalculateSpeed();
    }

    private void Start() {
        settings?.SetLife();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            settings?.Move(speed);
        }
    }

    protected virtual float CalculateSpeed() 
    {
        return speed + speed; // apenas para exemplificar o uso de um método virtual sobescrevendo o método da classe base
    }
}

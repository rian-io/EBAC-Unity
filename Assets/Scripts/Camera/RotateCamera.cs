using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;

    // Update is called once per frame
    private void Update()
    {
        float input = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up, input * speed * Time.deltaTime);
    }
}

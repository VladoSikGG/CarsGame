using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMode : MonoBehaviour
{
    private float _rotationSpeed = 0.4f;
    private float _currentRotation = 180f;
    

    private void Update()
    {
        print (_currentRotation);
        _currentRotation -= _rotationSpeed;
        transform.rotation = Quaternion.Euler(0, _currentRotation, 0);
    }
}

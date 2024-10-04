using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorController : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationDirection = Vector3.up;
    [SerializeField] private float _speed = 30f;

    private Vector3 _currentRotation;

    void Update()
    {
        _currentRotation = transform.eulerAngles;
        _currentRotation += _rotationDirection * Time.deltaTime * _speed;

        transform.eulerAngles = _currentRotation;  
    }
}

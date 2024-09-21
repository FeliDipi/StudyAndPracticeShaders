using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float _followSpeed = 0.75f;
    [SerializeField] private Transform _target;

    private Vector3 _currentPosition;

    void Update()
    {
        _currentPosition = transform.position;
        _currentPosition.x = Mathf.Lerp(transform.position.x, _target.position.x, Time.deltaTime * _followSpeed);

        transform.position = _currentPosition;
    }
}

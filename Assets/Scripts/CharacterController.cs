using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private Animator _animator;

    private float _horizontalInput;
    private float _verticalInput;
    private Vector3 _movement;

    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        _animator.SetFloat("x", _horizontalInput);
        _animator.SetFloat("y", _verticalInput);

        _movement = new Vector3(_horizontalInput, 0f, _verticalInput).normalized;

        if (_movement.magnitude >= 0.1f)
        {
            transform.Translate(_movement * _speed * Time.deltaTime, Space.World);

            Quaternion targetRotation = Quaternion.LookRotation(_movement);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);
        }
    }
}

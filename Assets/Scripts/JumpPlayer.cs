using UnityEngine;


public class JumpPlayer : IJump
{
    #region Fields
    protected Transform _transform;
    protected Vector3 _movement;
    private float _moveSpeed = 6.0f;
    private float _jumpSpeed = 15.0f;
    private float _gravity = -9.8f;
    private float _terminalVelocity = -10.0f;
    private float _minFall = -1.5f;
    public float _vertSpeed;
    public CharacterController _characterController;
    public ControllerColliderHit _contact;
    #endregion

    #region Properties
    public float MoveSpeed => _moveSpeed;
    public float JumpSpeed => _jumpSpeed;
    public float Gravity => _gravity;
    public float TerminalVelocity => _terminalVelocity;
    public float MinFall => _minFall;
    #endregion

    public void Jump()
    {
        bool hitGround = false;
        RaycastHit hit;
        if (_vertSpeed < 0 && Physics.Raycast(_transform.position, Vector3.down, out hit))
        {
            float check = (_characterController.height + _characterController.radius) / 1.9f;
            hitGround = hit.distance <= check;
        }

        if (hitGround)
        {
            if (Input.GetButtonDown("Jump"))
                _vertSpeed = _jumpSpeed;
            else
                _vertSpeed = _minFall;
        }
        else
        {
            _vertSpeed += _gravity * 5 * Time.deltaTime;
            if (_vertSpeed < _terminalVelocity)
                _vertSpeed = _terminalVelocity;
            if (_characterController.isGrounded)
            {
                if (Vector3.Dot(_movement, _contact.normal) < 0)
                    _movement = _contact.normal * _moveSpeed;
                else
                    _movement += _contact.normal * _moveSpeed;
            }
        }

        _movement.y = _vertSpeed;

        _movement *= Time.deltaTime;
        _characterController.Move(_movement);
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        _contact = hit;
    }

}

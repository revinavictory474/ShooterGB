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
    public CharacterController characterController;
    public ControllerColliderHit contact;
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
            float check = (characterController.height + characterController.radius) / 1.9f;
            hitGround = hit.distance <= check;
        }

        if (hitGround)
        {
            if (Input.GetButtonDown("Jump"))
                _vertSpeed = JumpSpeed;
            else
                _vertSpeed = MinFall;
        }
        else
        {
            _vertSpeed += Gravity * 5 * Time.deltaTime;
            if (_vertSpeed < TerminalVelocity)
                _vertSpeed = TerminalVelocity;
            if (characterController.isGrounded)
            {
                if (Vector3.Dot(_movement, contact.normal) < 0)
                    _movement = contact.normal * MoveSpeed;
                else
                    _movement += contact.normal * MoveSpeed;
            }
        }

        _movement.y = _vertSpeed;

        _movement *= Time.deltaTime;
        characterController.Move(_movement);
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        contact = hit;
    }

}

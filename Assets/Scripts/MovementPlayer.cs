using UnityEngine;


public class MovementPlayer : IMove
{
    #region Fields
    private Transform target;
    public Transform _transform;
    protected Vector3 _movement;
    public CharacterController _characterController;
    #endregion

    #region Properties
    public float Speed { get; set; }
    public float SpeedRotate { get; set; }
    #endregion


    public MovementPlayer(Transform transform, float speed, float speedRotate, Transform cameraTransform, CharacterController characterController)
    {
        _transform = transform;
        Speed = speed;
        SpeedRotate = speedRotate;
        target = cameraTransform;
        _characterController = characterController;
    }


    public void Move()
    {
        _movement = Vector3.zero;
        float horInput = Input.GetAxis("Horizontal");
        float verInput = Input.GetAxis("Vertical");
        if (horInput != 0 || verInput != 0)
        {
            _movement.z = verInput * Speed;
            _movement.x = horInput * Speed;
            Debug.Log(_movement.z);
            _movement = Vector3.ClampMagnitude(_movement, Speed);

            Quaternion tmp = target.rotation;
            target.eulerAngles = new Vector3(0, target.eulerAngles.y, 0);
            _movement = target.TransformDirection(_movement);
            target.rotation = tmp;

            Quaternion direction = Quaternion.LookRotation(_movement);
            _transform.rotation = Quaternion.Lerp(_transform.rotation, direction, SpeedRotate * Time.deltaTime);

            _movement *= Time.deltaTime;
            _characterController.Move(_movement);
        }
    }
}

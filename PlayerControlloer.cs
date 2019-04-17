using UnityEngine;


[RequireComponent(typeof(PlayerMotor))]
public class PlayerControlloer : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float lookSensitivity = 3f;

    private PlayerMotor motor;


    void Start()
    {
        motor = GetComponent<PlayerMotor>();

    }
    void Update()
    {
        //calculate movement velocity as a 3d vector
        float _xMov = Input.GetAxisRaw("Horizontal");
        float _zMov = Input.GetAxisRaw("Vertical");

        Vector3 _movHorizontal = transform.right * _xMov;
        Vector3 _movVertical = transform.forward * _zMov;

        //final movement vector
        Vector3 _velocity = (_movHorizontal + _movVertical).normalized * speed;
        // apply movement
        motor.Move(_velocity);

        //calculate rotation as  3D vector (turning around)
        float _yRot = Input.GetAxisRaw("Mouse X");

        Vector3 _rotation = new Vector3(0f, _yRot, 0f) * lookSensitivity;
        // apply rotation
        motor.Rotate(_rotation);

        if (Input.GetKey(KeyCode.X))
        {
            transform.position += Vector3.up/100;
        }
        else if (Input.GetKey(KeyCode.Z))
        {
            transform.position -= Vector3.up/20;

        }

    }

}

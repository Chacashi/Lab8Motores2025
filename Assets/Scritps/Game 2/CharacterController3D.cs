using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController3D : MonoBehaviour
{
    private Rigidbody myRB;
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    Vector2 direction;
    private bool canJump;

    private void Awake()
    {
        myRB = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        ApplyPhysics();
    }
    
    public void OnJump()
    {
        if (canJump)
        {
            myRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            canJump = false;
        }
       
    }

    public void ApplyPhysics()
    {
        myRB.linearVelocity = new Vector3(direction.x *speed, myRB.linearVelocity.y,
            direction.y * speed);
    }
    public void OnMovement(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 7)
        {
            canJump = true;
        }
    }
}

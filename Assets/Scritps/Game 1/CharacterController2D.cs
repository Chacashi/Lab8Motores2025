using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController2D : MonoBehaviour
{
    Rigidbody2D myRBD2;
    [SerializeField] private float velocity;
    Vector2 direction;

    private void Awake()
    {
        myRBD2 = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        myRBD2.linearVelocity = new Vector2(direction.x * velocity, direction.y * velocity);    

    }

    public void OnMovement(InputAction.CallbackContext context)
    {
       direction = context.ReadValue<Vector2>();        
    }
}

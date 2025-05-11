using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform[] pivotPoints;
    private Rigidbody rb;
    public int currentPivotIndex = 0;
    [SerializeField] private float speed;
    Vector3 direction;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        
        Move();
    }
    private void Move()
    {
        direction = (pivotPoints[currentPivotIndex].position - transform.position).normalized;
        rb.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);
        //rb.linearVelocity = new Vector3(direction.x*speed, rb.linearVelocity.y, direction.z*speed);
        UpdatePivot();
    }

    private void UpdatePivot()
    {
        if (Vector3.Distance(transform.position, pivotPoints[currentPivotIndex].position) < 0.1f)
        {
            Debug.Log("Gaaa");
            currentPivotIndex++;
            if (currentPivotIndex > pivotPoints.Length-1)
            {
                currentPivotIndex = 0;
            }
           
        }
    }
}

using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private Vector3 AngleRotations;
    private Quaternion rotation;


    private void Update()
    {
        QuaternionRotation();
    }
    private void QuaternionRotation()
    {
        rotation = Quaternion.Euler(0,AngleRotations.y*Time.deltaTime,0);
        transform.rotation = rotation * transform.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 6)
        {
            GameManager.Instance.GainCoin();
            Destroy(this.gameObject);
        }
    }
}

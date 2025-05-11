using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int lifeRecover;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 6)
        {
            GameManager.Instance.ModifyLife(lifeRecover);
            Destroy(this.gameObject);
        }
    }
}

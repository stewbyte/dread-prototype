using UnityEngine;

public class pickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Valuable"))
        {
            Destroy(other.gameObject);
        }
    }
}

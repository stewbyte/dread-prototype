using UnityEngine;

public class pickup : MonoBehaviour
{
    [SerializeField] AudioClip sound;

    AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Valuable"))
        {
            Destroy(other.gameObject);
            audioSource.PlayOneShot(sound);
        }
    }
}

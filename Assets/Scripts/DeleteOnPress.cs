using Unity.VisualScripting;
using UnityEngine;

public class DeleteOnPress : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            Destroy(gameObject);
        }
    }
}

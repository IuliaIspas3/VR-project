using UnityEngine;

public class touchTrash : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PaperBin"))
        {
            Destroy(gameObject);

            Debug.Log("Paper destroyed after touching PaperBin.");
        }
    }
}

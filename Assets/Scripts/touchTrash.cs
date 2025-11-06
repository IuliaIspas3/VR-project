using UnityEngine;

public class touchTrash : MonoBehaviour
{
    [SerializeField] private string trashTag;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(trashTag))
        {
            Destroy(gameObject);

            Debug.Log("Paper destroyed after touching PaperBin.");
        }
    }
}

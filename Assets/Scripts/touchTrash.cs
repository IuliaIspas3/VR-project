using UnityEngine;

public class touchTrash : MonoBehaviour
{
    [SerializeField] private string trashTag;
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag(trashTag))
        {
            Destroy(gameObject);

            Debug.Log(trashTag + " destroyed after touching " + trashTag + " bin");
        }
        else
        {
            Debug.Log("Wrong bin!");
        }
    }
}

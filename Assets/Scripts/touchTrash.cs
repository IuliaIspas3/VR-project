using UnityEngine;

public class touchTrash : MonoBehaviour
{
    private float distance;
    private AddScoreScript scoreScript;
    private UIManager ui;

    [SerializeField] private Camera camera;
    private string myTag;
    

    void Awake()
{
    myTag = gameObject.tag;
    scoreScript = FindObjectOfType<AddScoreScript>();
}

    private void OnTriggerEnter(Collider other)
    {
        string trashTag = other.transform.tag;
        if (other.transform.CompareTag(myTag))
        {
            Debug.Log(trashTag + " destroyed after touching " + other.transform.tag + " bin");
            scoreScript.UpdateScore(calculateScore());
            FindObjectOfType<UIManager>().ShowMessage("+ " + calculateScore() + " points!");
        }
        else
        {
            scoreScript.UpdateScore(-1);
            FindObjectOfType<UIManager>().ShowMessage("- 1 point :(");
        }
        Destroy(other);
    }


private int calculateScore()
    {
        int score = 5;
        float distance = Vector3.Distance(camera.transform.position, transform.position);;
        score = score + (int)distance;
        return score;
    }
}

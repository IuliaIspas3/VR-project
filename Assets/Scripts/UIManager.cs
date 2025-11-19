using UnityEngine;
using TMPro;
using System.Collections;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Canvas canvas;              
    [SerializeField] private TextMeshProUGUI messageText; 

    private void Awake()
    {
        if (canvas != null)
            canvas.gameObject.SetActive(false); 
    }

    public void ShowMessage(string message)
    {
        StartCoroutine(ShowMessageCoroutine(message));
    }

    private IEnumerator ShowMessageCoroutine(string message)
    {
        if (canvas != null)
            canvas.gameObject.SetActive(true); 

        if (messageText != null)
            messageText.text = message;         

        Debug.Log(message);

        yield return new WaitForSeconds(5f);

        if (canvas != null)
            canvas.gameObject.SetActive(false); 

        Debug.Log("BYE");
    }
}


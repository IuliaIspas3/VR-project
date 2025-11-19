using UnityEngine;
using TMPro;

public class AddScoreScript : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private int totalScore = 0;

    void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateScore(int score)
    {
        totalScore += score;
        scoreText.text = totalScore.ToString();
    }
}

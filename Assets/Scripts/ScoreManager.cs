using UnityEngine;
using TMPro; // TextMeshPro kullanıyorsan

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager I;
    public TMP_Text scoreText;
    int score = 0;

    void Awake()
    {
        I = this;
    }

    void Start()
    {
        UpdateScoreText();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = "Skor: " + score;
    }
}

using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;  // ? INSTANCE BURADA TANIMLI

    public int score;
    public TMP_Text scoreText;

    private void Awake()
    {
        Instance = this;   // ? INSTANCE BURADA AYARLANIYOR
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = score.ToString();
    }
}
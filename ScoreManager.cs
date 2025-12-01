using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;              // Baþlangýç skoru
    public TextMeshProUGUI scoreText; // <-- TextMeshPro tipi

    void Start()
    {
        UpdateScoreUI();
    }

    // Score artýrma fonksiyonu
    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreUI();
    }

    // UI güncelleme
    void UpdateScoreUI()
    {
        if (scoreText != null)
            scoreText.text = "" + score;
    }
}
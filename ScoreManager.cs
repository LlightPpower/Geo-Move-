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
        UpdateSpeed();
    }
    void UpdateSpeed()
    {
        float newSpeed = 5f + (score / 10) * 0.5f;

        Prefab_Sc[] platforms = Object.FindObjectsByType<Prefab_Sc>(FindObjectsSortMode.None);

        foreach (Prefab_Sc platform in platforms)
        {
            platform.SetSpeed(newSpeed);
        }
    }
}
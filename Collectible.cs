using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int scoreValue = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager scoreManager = Object.FindFirstObjectByType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.AddScore(scoreValue); // ? BURASI DÜZELTÝLDÝ
            }

            Destroy(gameObject);
        }
    }
}
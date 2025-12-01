using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int scoreValue = 1; // Bu prefab geçtiðinde verilecek puan

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Yeni yöntem
            ScoreManager scoreManager = Object.FindFirstObjectByType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.IncreaseScore(scoreValue);
            }

            Destroy(gameObject);
        }
    }
}
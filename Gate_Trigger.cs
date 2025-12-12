using UnityEngine;

public class GateTrigger : MonoBehaviour
{
    private bool passed = false;

    private void OnTriggerEnter(Collider other)
    {
        if (passed) return;

        if (other.CompareTag("Player")) // ana kübe Player tag ver
        {
            ScoreManager.Instance.AddScore(1);
            passed = true;
        }
    }
}
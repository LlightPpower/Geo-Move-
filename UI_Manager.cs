using TMPro;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public TextMeshProUGUI counterText;

    void Update()
    {
        if (GameManager.instance != null)
        {
            counterText.text = "Score: " + GameManager.instance.destroyedPlatformCount;
        }
    }
}

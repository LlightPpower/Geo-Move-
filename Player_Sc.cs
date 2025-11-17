using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Sc : MonoBehaviour
{
    // X lane
    private float xPos;
    private float leftLaneX = -0.5f;
    private float rightLaneX = 0.5f;

    // Y lane
    private float yPos;
    private float minY = -0.5f;
    private float maxY = 0.5f;

    void Start()
    {
        // Baþlangýç sahnedeki pozisyon
        xPos = transform.position.x;
        yPos = transform.position.y;
    }

    void Update()
    {
        if (Keyboard.current == null) return;

        // --- X ekseni ---
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            xPos = leftLaneX;
        }
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            xPos = rightLaneX;
        }

        // --- Y ekseni ---
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            yPos += 1f;
        }
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            yPos -= 1f;
        }

        // Y eksenini sýnýrlama
        yPos = Mathf.Clamp(yPos, minY, maxY);

        UpdatePosition();
    }

    void UpdatePosition()
    {
        transform.position = new Vector3(xPos, yPos, transform.position.z);
        Debug.Log($"X = {xPos}, Y = {yPos}");
    }
}
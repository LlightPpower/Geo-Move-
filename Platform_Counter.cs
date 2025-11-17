using UnityEngine;

public class Platform_Counter : MonoBehaviour
{
    private void OnDestroy()
    {
        // Sadece Main_Platform_1,2,3 isimli platformlar sayýlacak
        if (gameObject.name.StartsWith("Main_Platform_"))
        {
            GameManager.instance.AddPlatform();
        }
    }
}

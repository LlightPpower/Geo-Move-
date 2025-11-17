using UnityEngine;

public class Starting_Platform : MonoBehaviour
{
    public float moveSpeed = 5f;   // Negatif Z yönünde hýz
    public float destroyZ = -10f;  // Bu Z deðerinin altýna düþünce obje silinir

    void Update()
    {
        // Negatif Z yönünde hareket
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        // Belirli bir Z deðerinin altýna indiðinde kendini yok et
        if (transform.position.z <= destroyZ)
        {
            Destroy(gameObject);
        }
    }
}
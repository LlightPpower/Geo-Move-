using UnityEngine;

public class Prefab_Sc : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float destroyZ = -15f;
    public float respawnZ = 25f;
    public GameObject[] doors; // Platform_C1, Platform_C2, Platform_C3, Platform_C4
    
    GameObject prefabRef;

    void Start()
    {
        // Objeyi oluþturan prefab referansýný al
        prefabRef = gameObject;
        ResetAllDoors();
        DisableRandomDoor();
    }

    void Update()
    {
        // Negatif Z yönünde hareket
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        // Yok olma noktasýna geldiyse:
        if (transform.position.z <= destroyZ)
        {
            // Yeni spawn konumu
            Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y, respawnZ);

            // Prefab üzerinden yeni platform oluþtur
            Instantiate(prefabRef, spawnPos, Quaternion.identity);

            // Eski platformu sil
            Destroy(gameObject);
        }   
    }
    void DisableRandomDoor()
    {
        if (doors.Length == 0)
        {
            Debug.LogWarning("Kapýlar atanmadý!");
            return;
        }

        // Rastgele bir kapý seç
        int randomIndex = Random.Range(0, doors.Length);

        // Seçilen kapýyý devre dýþý býrak
        doors[randomIndex].SetActive(false);
    }
    void ResetAllDoors()
    {
        foreach (GameObject door in doors)
        {
            door.SetActive(true);  // bütün kapýlarý tekrar aç
        }
    }
    public void SetSpeed(float newSpeed)
    {
        moveSpeed = newSpeed;
    }

}
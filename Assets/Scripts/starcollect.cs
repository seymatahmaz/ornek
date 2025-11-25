using UnityEngine;

public class StarCollect : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Sadece Player çarptığında çalışsın
        if (other.CompareTag("Player"))
        {
            // 1 puan ekle
            ScoreManager.I.AddScore(1);

            // Bu yıldızı sahneden kaldır (istersen Destroy yerine SetActive(false) kullan)
            gameObject.SetActive(false);
        }
    }
}

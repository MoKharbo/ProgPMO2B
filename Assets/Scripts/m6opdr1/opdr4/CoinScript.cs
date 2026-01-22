using UnityEngine;

public class CoinScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CoinsManager.AddScore(1);
            Destroy(gameObject);
        }
    }
}

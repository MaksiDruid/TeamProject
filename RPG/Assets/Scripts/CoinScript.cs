using UnityEngine;

public class CoinScript : MonoBehaviour
{
    [SerializeField] private int coinCost;
    [SerializeField] private AudioClip coinSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.ChangeCoinsCount(coinCost);
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            Destroy(gameObject);
        }               
    }
}

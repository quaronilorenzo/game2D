using UnityEngine;

public class Health : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerHealth player = other.GetComponent<PlayerHealth>();
        if (player != null && player.GetHealth() < player.GetMaxHealth())
        {
            player.ChangeHealth(1);
            Destroy(gameObject);
        }
    }
}

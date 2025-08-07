using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        PlayerHealth player = other.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.ChangeHealth(-1);
        }
    }
}

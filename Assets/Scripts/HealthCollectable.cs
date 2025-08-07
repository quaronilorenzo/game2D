using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerHealth h = other.GetComponent<PlayerHealth>();
        if (h != null && h.health < h.maxHealth)
        {
            h.changeHealth(1);
            Destroy(gameObject);
        }
    }

}

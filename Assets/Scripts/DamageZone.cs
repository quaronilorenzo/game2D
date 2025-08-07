using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class DamageZone : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        PlayerHealth h = other.GetComponent<PlayerHealth>();
        if (h != null && h.health > 0)
        {
            h.changeHealth(-1);
        }
    }
    
}

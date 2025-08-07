using System.Collections.Specialized;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 5;
    private int currentHealth;
    public float timeInvincible = 0.7f;
    bool isInvincible;
    private float damageCooldown;
    public int health { get { return currentHealth; } }
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void changeHealth(int amount)
    {
        if (amount < 0)
        {
            if (isInvincible)
            {
                return;
            }
            isInvincible = true;
            damageCooldown = timeInvincible;
        }


        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
       //  Debug.Log(currentHealth + "/" + maxHealth);
    }
    void Update()
    {
        if (isInvincible)
        {
            damageCooldown -= Time.deltaTime;
            if (damageCooldown < 0)
            {
                isInvincible = false;
            }
        }
        Debug.Log(currentHealth); // vedo la vita del personaggio
    }
}

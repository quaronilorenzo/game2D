using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 5;
    public float timeInvincible = 1f;

    int currentHealth;
    bool isInvincible;
    float invincibilityTimer;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (isInvincible)
        {
            invincibilityTimer -= Time.deltaTime;
            if (invincibilityTimer <= 0f)
            {
                isInvincible = false;
            }
        }
    }

    public void ChangeHealth(int amount)
    {
        if (amount < 0)
        {
            if (isInvincible)
                return;

            isInvincible = true;
            invincibilityTimer = timeInvincible;
        }

        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log("Vita attuale: " + currentHealth + "/" + maxHealth);
    }

    public bool IsInvincible()
    {
        return isInvincible;
    }

    public int GetHealth()
    {
        return currentHealth;
    }

    public int GetMaxHealth()
    {
        return maxHealth;
    }
}

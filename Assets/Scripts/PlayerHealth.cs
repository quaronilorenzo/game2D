using System.Collections.Specialized;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 5;
    private int currentHealth;
    public int health { get { return currentHealth; }}
    void Start()
    {
        currentHealth = 1;
    }
    public void changeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
       //  Debug.Log(currentHealth + "/" + maxHealth);
    }
    void Update()
    {
        Debug.Log(currentHealth);
    }
}

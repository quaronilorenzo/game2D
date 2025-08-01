using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        Vector2 position = transform.position;
        position.x += 0.1f;
        position.y += 0.1f;
        transform.position = position;
    }
}
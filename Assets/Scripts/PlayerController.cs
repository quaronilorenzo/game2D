using UnityEngine;

public class PlayerController: MonoBehaviour
{
    public float speed = 3f;
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveX, moveY);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}

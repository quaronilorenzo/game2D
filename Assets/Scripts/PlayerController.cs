using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 6f;

    void Update()
    {
        if (Keyboard.current == null)
            return;

        float horizontal = 0f;
        float vertical = 0f;

        if (Keyboard.current.aKey.isPressed)
            horizontal = -1f;
        else if (Keyboard.current.dKey.isPressed)
            horizontal = 1f;

        if (Keyboard.current.wKey.isPressed)
            vertical = 1f;
        else if (Keyboard.current.sKey.isPressed)
            vertical = -1f;

        Vector2 movement = new Vector2(horizontal, vertical);
        if (movement.sqrMagnitude > 1f)
            movement.Normalize();

        transform.Translate(movement * speed * Time.deltaTime);
    }
}

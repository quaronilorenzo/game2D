using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 3f;
    public InputAction LeftAction;
    public InputAction MoveAction;
    void Start()
    {
        // QualitySettings.vSyncCount = 0;
        // Application.targetFrameRate = 120;
        MoveAction.Enable();
    }
    void Update()
    {
        Vector2 move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
        Vector2 position = (Vector2)transform.position + move * speed * Time.deltaTime;
        transform.position = position;
    }
}

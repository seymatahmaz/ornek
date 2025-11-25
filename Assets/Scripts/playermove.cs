using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal"); // A-D / ok tuşları
        float v = Input.GetAxis("Vertical");   // W-S / ok tuşları

        Vector3 dir = new Vector3(h, 0f, v);
        rb.MovePosition(rb.position + dir * speed * Time.fixedDeltaTime);
    }
}

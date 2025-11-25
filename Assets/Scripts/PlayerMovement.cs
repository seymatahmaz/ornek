using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private PlayerControls playerControls;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        playerControls = new PlayerControls();
        playerControls.Player1.Jump.performed += Jump;
        rb = GetComponent<Rigidbody2D>();
        
    }
    
    void Jump(UnityEngine.InputSystem.InputAction.CallbackContext context){
        Debug.Log("jump");
        rb.AddForce(new Vector2(15,0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

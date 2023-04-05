using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of movement
    public float jumpForce = 10f; // Force of jump
    private Rigidbody rb;
    private bool isGrounded = true; // Flag for checking if player is on the ground

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Move forward
        Vector3 forwardMovement = transform.forward * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMovement);

        // Move left or right
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 horizontalMovement = transform.right * horizontalInput * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + horizontalMovement);

        // Check for jumping
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}

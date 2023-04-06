using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public GameObject YouWonPanel;
    public float jumpForce = 10f; 
    private Rigidbody rb;
    [SerializeField] private bool isGrounded = true; 

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
       
        Vector3 forwardMovement = transform.forward * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMovement);

        
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 horizontalMovement = transform.right * horizontalInput * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + horizontalMovement);

        
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
      private void OnTriggerEnter(Collider other)
      {
        if(other.gameObject.CompareTag("Endpoint"))
        {
           YouWon();
        }
      }
  
        
    
    public void YouWon()
    {
       
        Time.timeScale = 0;
        YouWonPanel.SetActive(true);
    
    }
}

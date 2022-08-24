using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    [SerializeField] private LayerMask groundLayer;
    private Rigidbody2D rb;
    //private Animator anim;
    private BoxCollider2D boxCollider2D;
    private float horizontalInput;

    private void Awake()
    {
        // Grab References
        rb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");


        // Flip player depending on direction of movement
        if (horizontalInput > 0.01f)
        {
            transform.localScale = Vector3.one;
        }
        else if (horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }

        // Player left/right movement
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);

        
        // Set Animator Parameters (When anims are set up)
        // anim.SetBool("run", horizontalInput != 0);
        // anim.SetBool("grounded", IsGrounded());

    }

    private void Jump()
    {
        if (IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            //anim.SetTrigger("jump"); // When anims and sprites are chosen.
        }
        
    }
    
    /**
     * This detects if the player is on the ground. Ground layer must be set.
     * */
    private bool IsGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0, Vector2.down, 0.1f, groundLayer);

        return raycastHit.collider != null;
    }

}


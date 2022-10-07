using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    [SerializeField] private LayerMask groundLayer;
    private Rigidbody2D rb;
    private Animator anim;
    private BoxCollider2D boxCollider2D;
    private float horizontalInput;
    public bool allowedToMoved = true;

    private void Awake()
    {
        GetReferences();
    }

    private void GetReferences()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (allowedToMoved)
        {
            FlipPlayer();
            // Jump if 'W' or spacebar pressed
            if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W))
            {
                Jump();
            }
            // Player left/right movement
            rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);

            SetAnimatorParams();
        }
       


    }

    // Set Animator Parameters
    private void SetAnimatorParams()
    {
        anim.SetBool("run", horizontalInput != 0);
        anim.SetBool("grounded", IsGrounded());
    }

    // Flip player depending on direction of movement
    private void FlipPlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput > 0.01f)
        {
            transform.localScale = Vector3.one;
        }
        else if (horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    private void Jump()
    {
        if (IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            anim.SetTrigger("jump"); // When anims and sprites are chosen.
        }

    }

    // This detects if the player is on the ground. Ground layer must be set.
    private bool IsGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.Raycast(transform.position, Vector2.down, boxCollider2D.bounds.extents.y + 0.1f, groundLayer);

        return raycastHit.collider != null;
    }

}


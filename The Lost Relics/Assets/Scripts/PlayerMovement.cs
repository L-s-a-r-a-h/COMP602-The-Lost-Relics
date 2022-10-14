using System;
using System.Collections;
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
    private bool hurtAnimPlaying;
    private bool deadAnimPlaying;
    public bool DeadAnimDone { private set; get; }
    private bool knockedBack;


    private void Awake()
    {
        GetReferences();
        hurtAnimPlaying = false;
        deadAnimPlaying = false;
        DeadAnimDone = false;
        knockedBack = false;
    }

    private void GetReferences()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        // check if dead and play dead animation if player is dead
        if (IsDead())
        {
            Freeze();
            if (!deadAnimPlaying && !DeadAnimDone)
            {
                anim.SetTrigger("dead");
                deadAnimPlaying = true;
            }
            return;
        }

        // freeze movement if talking with NPC
        if (IsTalking())
        {
            Freeze();
            return;
        }

        // flips player depending on direction of movement
        HorizontalMovement();

        // Jump if 'W' or spacebar pressed
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W))
        {
            Jump();
        }

        // Player left/right movement   

        SetAnimatorParams();
    }

    private bool IsDead()
    {
        return Health.Dead;
    }

    private void Freeze()
    {
        rb.velocity = new Vector2(0, 0);
        anim.SetBool("run", false);
        anim.SetBool("falling", false);
        anim.SetBool("grounded", true);
    }

    // Checks if the player is in an NPC dialogue (needs the HUDCanvas prefab).
    private bool IsTalking()
    {
        bool talking = false;

        try
        {
            // find if the user is in NPC dialogue
            DialogueManager dm = GameObject.Find("DialogueManager").GetComponent<DialogueManager>();
            talking = dm.talking;
        }
        catch (NullReferenceException)
        {
            // exit if the scene doesn't have the needed prefab.
            Debug.LogError("Missing HUDCanvas prefab");
        }

        return talking;
    }

    // Set Animator Parameters
    private void SetAnimatorParams()
    {
        anim.SetBool("run", horizontalInput != 0);
        anim.SetBool("grounded", IsGrounded());
        anim.SetBool("falling", IsFalling());
        CheckHurt();
        anim.SetBool("hurting", hurtAnimPlaying);
    }

    private void CheckHurt()
    {
        if (Health.Hurt == true && hurtAnimPlaying == false)
        {
            anim.SetTrigger("hurt");
            hurtAnimPlaying = true;
            StartCoroutine(Knockback());
        }
    }

    private IEnumerator Knockback()
    {
        knockedBack = true;

        rb.velocity = new Vector2(0, 0);
        rb.AddForce(new Vector2(-transform.localScale.x * 7.5f, 7.5f), ForceMode2D.Impulse);

        yield return new WaitForSeconds(1);

        knockedBack = false;
    }

    // used in an animation event
    public void HurtAnimationDone()
    {
        Health.Hurt = false;
        hurtAnimPlaying = false;
    }

    // used in an animation event
    public void DeathAnimationDone()
    {
        deadAnimPlaying = false;
        DeadAnimDone = true;
    }

    private bool IsFalling()
    {
        if (rb.velocity.y < -0.01f)
        {
            return true;        
        }

        return false;
    }

    private void HorizontalMovement()
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

        // move
        if (knockedBack)
        {
            if ((horizontalInput > 0.01f && rb.velocity.x <= speed) || 
                (horizontalInput < -0.01f && rb.velocity.x >= -speed))
            {
                rb.velocity += new Vector2(horizontalInput, 0);
            }        
        }
        else
        {
            rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
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


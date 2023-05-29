using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mecha_Escalade : MonoBehaviour
{
    public float ClimbSpeed = 3f;
    public Transform ClimbCheck;
    public LayerMask ClimbLayer;
    private Rigidbody2D rb;
    [SerializeField]private bool isClimbing = false;
    private float VerticalValue = 0f;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isClimbing)
        {
            isClimbing = Physics2D.OverlapCircle(ClimbCheck.position, 0.2f, ClimbLayer);
        }
        if (isClimbing)
        {
            VerticalValue = Input.GetAxisRaw("Vertical");
            rb.velocity = new Vector2(rb.velocity.x, VerticalValue * ClimbSpeed);
            rb.isKinematic = true;
            rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            isClimbing = Physics2D.OverlapCircle(ClimbCheck.position, 0.2f, ClimbLayer);
            anim.SetFloat("IsClimbing", Mathf.Abs(VerticalValue));
        
        
        }
        else
        {
            rb.isKinematic = false;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;

            rb.gravityScale = 3f;
        }
        anim.SetBool("Escalade", isClimbing);
    }
}

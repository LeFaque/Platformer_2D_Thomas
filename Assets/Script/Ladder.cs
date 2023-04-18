using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    public float ClimbSpeed = 3f;
    public Transform ClimbCheck;
    public LayerMask ClimbLayer;
    private Rigidbody2D rb;
    [SerializeField] private bool isLadder = false;
    private float VerticalValue = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLadder)
        {
            isLadder = Physics2D.OverlapCircle(ClimbCheck.position, 0.2f, ClimbLayer);
        }
        if (isLadder)
        {
            VerticalValue = Input.GetAxisRaw("Vertical");
            rb.velocity = new Vector2(rb.velocity.x, VerticalValue * ClimbSpeed);
            rb.gravityScale = 0f;
            isLadder = Physics2D.OverlapCircle(ClimbCheck.position, 0.2f, ClimbLayer);
        }
        else
        {
            rb.gravityScale = 3f;
        }
    }
}


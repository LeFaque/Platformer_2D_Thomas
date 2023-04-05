using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Commande : MonoBehaviour
{
    public float moveSpeed = 5f; // vitesse de déplacement
    public float jumpForce = 10f; // force de saut
    public Transform groundCheck; // objet qui vérifie si le joueur touche le sol
    public LayerMask groundLayer; // couche du sol
    private SpriteRenderer sr;
    private Rigidbody2D rb;
    private bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 3;
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // vérifie si le joueur touche le sol
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        // déplacement horizontal
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // Turn
        if (moveInput != 0)
        {
            if (moveInput > 0)
            {
                transform.localScale = new Vector2(1.5f, 1.5f); // tourne le personnage à droite
                //sr.flipX = false;
            }
            else
            {
                transform.localScale = new Vector2(-1.5f, 1.5f); // tourne le personnage à gauche
                //sr.flipX = true;
            }
        }
        

        // saut
        if (Input.GetKeyDown(KeyCode.JoystickButton0) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    //[SerializeField] Health healthBarRef;
    Rigidbody2D rb;
    Animator animController;

    private int maxHealth = 100;
    public int currentHealth = 100;
    Vector2 ref_velocity = Vector2.zero;
    public Vector3 PosRespawn = Vector3.zero;


    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animController= GetComponent<Animator>();
        currentHealth = maxHealth;
        //healthBarRef.SetMaxHealth(maxHealth);
        SetPosRespawn(PosRespawn);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(25);
        }

        if (currentHealth <= 0)
        {
            Death();
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        //healthBarRef.SetHealth(currentHealth);
    }

    public void Death()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        //animController.SetBool("isDead", true);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.transform.position = PosRespawn;
            currentHealth = 100;
            //animController.SetBool("isDead", false);
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }
    public void SetPosRespawn(Vector3 Position)
    {
        gameObject.transform.position = PosRespawn;
    }
}

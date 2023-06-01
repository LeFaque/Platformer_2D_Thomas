using UnityEngine;

public class Attack_Collision : MonoBehaviour
{
    [SerializeField] private PlayerHealth heal;
    [SerializeField] private int DamageAmount = 12;
    [SerializeField] private Animator anim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            heal.TakeDamage(DamageAmount);
            Debug.Log("OPS");
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            
            anim.SetBool("Atk",true);

        }
    }

}

using UnityEngine;

public class Attack_Collision : MonoBehaviour
{
    [SerializeField] public Player_Health heal;
    [SerializeField] public int DamageAmount = 12;
    [SerializeField] private Animator anim;
    Rigidbody2D rb;
    public int currentHealth;
    public Vector3 PosRespawn = Vector3.zero;
    public bool touchEau = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            heal.TakeDamage(DamageAmount);
            Debug.Log("OPS");
            Debug.Log("LEl");

            touchEau = true;

            
        }
        else
        {
            touchEau = false;
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

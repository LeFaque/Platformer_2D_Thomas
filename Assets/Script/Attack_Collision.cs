using UnityEngine;

public class Attack_Collision : MonoBehaviour
{
    [SerializeField] private PlayerHealth heal;
    [SerializeField] private int DamageAmount = 25;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            heal.TakeDamage(DamageAmount);
            Debug.Log("OPS");
        }
    }
}
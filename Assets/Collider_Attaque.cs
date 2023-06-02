using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Attaque : MonoBehaviour
{
    [SerializeField] private PlayerHealth heal;
    [SerializeField] public int DamageAmount = 25;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //heal.TakeDamage(DamageAmount);
            Debug.Log("OPS");
        }
    }
}

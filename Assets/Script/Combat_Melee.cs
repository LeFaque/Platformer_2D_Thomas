using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat_Melee : MonoBehaviour
{
    public Transform Attaque_Position;
    public LayerMask EnemyLayers;

    [SerializeField] private float Attaque_Range=0.6f;
    [SerializeField] private int Attaque_Dommage = 100;

    [SerializeField] private float Attaque_Rate = 2f; 
    private float CooldownAttack=0;

    private Animator anim;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }
    // Update is called once per frame
    void Update()
    {

        if (Time.time >= CooldownAttack)
        {
            if (Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.JoystickButton5))
            {
                Melee();
                CooldownAttack = Time.time + 1f / Attaque_Rate; //0.5s
            }
        }

    }

    private void Melee()
    {
        anim.SetBool("Atk", true);
        Collider2D[] HitEnnemi =Physics2D.OverlapCircleAll(Attaque_Position.position,Attaque_Range,EnemyLayers);


        foreach (Collider2D Ennemi in HitEnnemi)
        
            if (Ennemi.gameObject.layer == LayerMask.NameToLayer("Petit_Ennemi"))
            {
                Ennemi.GetComponent<Health_little>().TakeDamage(Attaque_Dommage);
                Debug.Log("Hit " + Ennemi.name);
            }
            else
            {
                Ennemi.GetComponent<Health_big>().TakeDamage(Attaque_Dommage);
                Debug.Log("Hit " + Ennemi.name);
            }
        StartCoroutine(FinAtk());

        
    }
    private IEnumerator FinAtk()
    {
        yield return new WaitForSeconds(0.5f);
        anim.SetBool("Atk", false);

    }


    private void OnDrawGizmosSelected()
    {
        if (Attaque_Position == null)
            return;

        Gizmos.DrawWireSphere(Attaque_Position.position, Attaque_Range);
    }
}

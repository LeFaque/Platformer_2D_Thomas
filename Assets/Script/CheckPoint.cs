using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField]private Player_Health heal;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log(heal.PosRespawn);
            heal.PosRespawn = gameObject.transform.position;
            Destroy(gameObject);

            Debug.Log("test");
        }
    }
}

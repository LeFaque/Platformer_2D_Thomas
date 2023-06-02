using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class COLLECTIBLE : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject backpack;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.GetComponent <pickup>().score ++;
        backpack.SetActive (true);
        Destroy(gameObject);
    }

}

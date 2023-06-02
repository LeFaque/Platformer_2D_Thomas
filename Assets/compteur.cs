using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class compteur : MonoBehaviour
{
    static Text txte;
    [SerializeField] private pickup pick;
    // Start is called before the first frame update
    void Start()
    {
        txte = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        txte.text = pick.score + " / 8";
    }
}

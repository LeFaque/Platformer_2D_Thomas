using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attaque : MonoBehaviour
{
    [SerializeField] private GameObject collid;
    [SerializeField] private Animator anim;

    public void Atk()
    {
        collid.SetActive(true);
    }
    public void StopAtk()
    {
        collid.SetActive(false);
    }
    private void EndAtk()
    {
        anim.SetBool("Atk", false);
    }
}

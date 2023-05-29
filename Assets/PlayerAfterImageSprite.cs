using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerAfterImageSprite : MonoBehaviour
{
    [SerializeField]
    private float activeTime = 0.1f;
    private float timeActivated;
    private float alpha;

    [SerializeField]
    private float alphaSet = 0.8f;
    private float alphaMultiplier = 0.85f;

    private SpriteRenderer SR;
    private SpriteRenderer playerSr;

    private Color color;

    private void OnEnable()
    {
        SR = GetComponent<SpriteRenderer>();
        playerSr = GameObject.FindGameObjectWithTag("Sprite").GetComponent<SpriteRenderer>();

        alpha = alphaSet;
        SR.sprite = playerSr.sprite; // Utilisez le sprite du joueur pour le rendu de l'image résiduelle
        transform.position = playerSr.transform.position;
        transform.rotation = playerSr.transform.rotation;
        transform.localScale = playerSr.transform.localScale;
        timeActivated = Time.time;
    }

    private void Update()
    {
        alpha *= alphaMultiplier;
        color = new Color(1f, 1f, 1f, alpha);
        SR.color = color;

        if (Time.time >= (timeActivated + activeTime))
        {
            PlayerAfterImagePool.Instance.AddToPool(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDam : MonoBehaviour
{

    public int hitPoints = 2;
    public Sprite damagedSprite;
    public float damageImpactSpeed;

    private int currentHitPoints;
    private float damageImpactSpeedSqr;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rigidbody2d;
    private Collider2D collider2d;


    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody2d = GetComponent<Rigidbody2D>();
        collider2d = GetComponent<Collider2D>();
        currentHitPoints = hitPoints;
        damageImpactSpeedSqr = damageImpactSpeed * damageImpactSpeed;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag != "Damager")
            return;
        if (collision.relativeVelocity.sqrMagnitude < damageImpactSpeedSqr)
            return;

        spriteRenderer.sprite = damagedSprite;
        currentHitPoints--;

        if (currentHitPoints <= 0)
            Kill();

    }

    void Kill()
    {
        spriteRenderer.enabled = false;
        collider2d.enabled = false;
        rigidbody2d.isKinematic = true;
    }
    // Update is called once per frame
    void Update()
    {

    }
}


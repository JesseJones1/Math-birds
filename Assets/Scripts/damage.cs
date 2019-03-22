using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour {


    private Collider2D collider2d;
    public float damageImpactSpeed;
    private float damageImpactSpeedSqr;

    private Transform projectile;
    // Use this for initialization
    void Start () {
        projectile = GameObject.Find("AsteroidSprite").transform;
        collider2d = GetComponent<Collider2D>();

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.tag != "Damager")
            return;
        if (collision.relativeVelocity.sqrMagnitude < damageImpactSpeedSqr)
            return;

        if (collision.collider.tag == "Damager")
        {

            if (collision.collider.transform.GetChild(0).gameObject.name != "3_sprite") {
               
                //this.gameObject.GetComponent<Rigidbody2D>().mass = 100;
                GameObject[] _list = GameObject.FindGameObjectsWithTag("Plank");
                for (int i = 0; i < _list.Length; i++)
                {
                    _list[i].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
                }
                
            } ;
        }


    }

    // Update is called once per frame
    void Update () {

        
       
    }
}

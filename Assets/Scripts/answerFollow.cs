using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class answerFollow : MonoBehaviour {

   private Transform projectile;



    // Update is called once per frame
    private void Start()
    {
        projectile = GameObject.Find("AsteroidSprite").transform;
        
    }
    void Update () {
        Vector3 newPosition = transform.position;
        newPosition.x = projectile.position.x;
        newPosition.y = projectile.position.y;
        transform.position = newPosition;
        
	}
}

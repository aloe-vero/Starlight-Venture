using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Projectile à une rotation de 90 degreés, si Vector3.forward, le projectile tombe en bas
        // donc Vector3.up envoi le projectile horizontalement du terrain
        //Peut faut utiliser normalized dependant à la direction du joueur
        transform.Translate(Vector3.up *Time.deltaTime*speed);
    }
}

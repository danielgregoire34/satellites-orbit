using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OrbitingStationary : OrbitState

{
    public OrbitingIdle orbitingIdle;
    public float moveSpeed = 0;
    public Collider2D collider2D;

    public override OrbitState RunCurrentState()
    {
        collider2D.enabled = true;

        transform.position += transform.right * Time.deltaTime * moveSpeed;
        if (Input.GetButton("ReturnRock"))
        {
            return orbitingIdle;
            
        }

        return this;
    }
    


}

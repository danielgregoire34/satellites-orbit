using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitPull : OrbitState
{

    //public OrbitingIdle orbitingIdle;

    Rigidbody2D rb2d;
    public float moveSpeed;
    public OrbitingIdle orbitingIdle;
    public OrbitingMove orbitingMove;

   public bool stationary = false;
    public Transform newParent;

    public override OrbitState RunCurrentState()
    {

        transform.position -= transform.right * Time.deltaTime * moveSpeed;
        gameObject.transform.parent = null;
        if (Input.GetButton("Player1_Shoot"))
        {
            return orbitingMove;

        }
       

        return this;
    }

   

}
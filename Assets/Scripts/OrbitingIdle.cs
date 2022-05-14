using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitingIdle : OrbitState
{
    public OrbitingMove orbitingMoveState;
    public bool orbiting = true;
    public GameObject target;
    public Vector3 direction;
    public float speed;

    Vector3 originalPos;


    public override OrbitState RunCurrentState()
    {
        originalPos = gameObject.transform.position;



        transform.RotateAround(target.transform.position, direction, speed);
       
         if (Input.GetButton("Player1_Shoot"))
        {
            return orbitingMoveState;
        }
        if (Input.GetButton("RockPlatform"))
        {
            gameObject.transform.position = originalPos;
        }

        return this;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitingMove : OrbitState
{
    public OrbitPull orbitPull;
    Rigidbody2D rb2d;
    public float moveSpeed;
    public GameObject rocks;
   //public OrbitingStationary orbitingStationary;

    private float DOUBLE_CLICK_TIME = 0.2f;
    private float lastClickTime;
    public override OrbitState RunCurrentState()
    {
        float timeSinceLastClick = Time.time - lastClickTime;
      
        transform.position += transform.right * Time.deltaTime * moveSpeed;
        gameObject.transform.parent = null;
        if (Input.GetButton("Player1_SecondaryShoot"))
        {
            //return orbitingStationary;
            return orbitPull;
            if (timeSinceLastClick <= DOUBLE_CLICK_TIME)
            {
                //return orbitingStationary;
            }

        }

        return this;
    }

  


}

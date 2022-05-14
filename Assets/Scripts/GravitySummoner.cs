using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySummoner : MonoBehaviour
{

    private float DOUBLE_CLICK_TIME = 0.2f;
    private float lastClickTime;


    public GameObject rockPrefab = null;
    public static bool disabled = false;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      


        if (Input.GetButton("Vertical"))
        {
           
            rockPrefab.SetActive(true);
            /*float timeSinceLastClick = Time.time - lastClickTime;
            if (timeSinceLastClick <= DOUBLE_CLICK_TIME)
            {
                //rockPrefab.SetActive(true);
                Debug.Log("Orbital objects are Ready!");
            }
            else
            {

            }
            lastClickTime = Time.time;
            */
        }

        if (Input.GetButton("ReturnRock"))
        {
            rockPrefab.SetActive(false);
        }

    }

 


}

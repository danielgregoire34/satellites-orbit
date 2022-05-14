using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitGravityControl : MonoBehaviour
{
    public CharacterGravity characterGravity;
    public GravityPoint gravityPoint;
    public GameObject rocks;
    public CharacterDash characterDash;
    public CharacterStates characterStates;

    // Start is called before the first frame update
    void Start()
    {
        characterGravity = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterGravity>();
        //gravityPoint = GameObject.FindGameObjectWithTag("Rock").GetComponent<GravityPoint>();
        characterGravity.UpdateGravityPointsList();
        characterDash = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterDash>();
        characterStates = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterStates>();


    }

    // Update is called once per frame
    void Update()
    {

        if (characterDash.DashAuthorized())
        {
            Debug.Log("It works");

        }

        /*
        if (Input.GetButton("Player1_SecondaryShoot"))
        {
            rocks.SetActive(true);
            characterGravity.UpdateGravityPointsList();
        }
        else
        {
            rocks.SetActive(false);
            characterGravity.UpdateGravityPointsList();
        }
        */



    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="Force" )
        {
            Debug.Log("It works");


        }
    }

}

using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitProjectile : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float moveSpeed = 10;
    public GameObject rocks;
    public GameObject orbitGets;
    public CharacterGravity characterGravity;
    public Character character;
    public Projectile projectile;
    public bool goRocks = true;
   

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        //characterGravity = orbitGets.GetComponent<CharacterGravity>();
        characterGravity = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterGravity>();
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<Character>();
        projectile = GameObject.FindGameObjectWithTag("Rock").GetComponent<Projectile>();
     

        //character = orbitGets.GetComponent<Character>();
    }


    private void Awake()
    {
        StayInPlace();
    }

    private void Update()
    {
        if (Input.GetButton("Player1_SecondaryShoot")&&goRocks==true)
        {
            rocks.SetActive(true);
            StayInPlace();
            projectile.Speed = 0;
         
            characterGravity.UpdateGravityPointsList();
        }

     

    }

   

    void StayInPlace()
    {
        characterGravity.UpdateGravityPointsList();
        projectile.Speed = 0;
    }





}

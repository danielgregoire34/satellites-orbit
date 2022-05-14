using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;

public class OrbitingFire : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public CharacterGravity characterGravity;
    public GameObject orbitGets;
    public WeaponAim weaponAim;
    public Weapon weapon;

    // Start is called before the first frame update
    void Start()
    {
        //characterGravity = orbitGets.GetComponent<CharacterGravity>();
        characterGravity = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterGravity>();
        weaponAim = GameObject.FindGameObjectWithTag("Abilities").GetComponent<WeaponAim>();
        weapon = GameObject.FindGameObjectWithTag("Abilities").GetComponent<Weapon>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Player1_Shoot"))
        {
            characterGravity.UpdateGravityPointsList();
            Shoot();
           
        }
        if (Input.GetButtonDown("Player1_SecondaryShoot"))
        {
          
            characterGravity.UpdateGravityPointsList();

        }

    }

    void Shoot()
    {
        
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }



}

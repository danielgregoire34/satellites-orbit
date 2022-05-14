using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;


public class BounceBack : MonoBehaviour
{
    public GameObject orbitColiision;
    public CharacterDash characterDash;
    public CharacterJump characterJump;
    public DamageOnTouch damageOnTouch;


    // Start is called before the first frame update
    void Start()
    {
        characterDash = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterDash>();
        characterJump = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterJump>();
        damageOnTouch = GameObject.FindGameObjectWithTag("Force").GetComponent<DamageOnTouch>();

    }

    // Update is called once per frame
    void Update()
    {
        if (characterDash._cooldownTimeStamp>Time.time)
        {
            orbitColiision.SetActive(true);
            
        }
        else
        {
            orbitColiision.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            characterJump.ResetNumberOfJumps();
            
            //Debug.Log("It Works");
        }
       
       
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Weapon weaponToEquip;

    public GameObject effectPickup;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Instantiate(effectPickup, transform.position,Quaternion.identity);
             collision.GetComponent<Player>().ChangeWeapon(weaponToEquip); 
             Destroy(gameObject);
        }
    }
}

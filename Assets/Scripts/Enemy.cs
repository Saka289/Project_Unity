using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;

    [HideInInspector]
    public Transform player;

    public float speed;

    public float timeBetweenAttacks;

    public int damage;
    public int pickupChange;
    public GameObject[] pickups;

    public int healthPickupChange;
    public GameObject healPickup;

    public GameObject deathEffect;

    public GameObject blood;

    public virtual void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            int randomNumber = Random.Range(0, 101);
            if(randomNumber < pickupChange)
            {
                GameObject randomPickup = pickups[Random.Range(0, pickups.Length)];
                Instantiate(randomPickup, transform.position, transform.rotation);
            }
            int randomHealth = Random.Range(1, 101);
            if (randomHealth < healthPickupChange)
            {
                Instantiate(healPickup, transform.position, transform.rotation);
            }
           // Instantiate(blood, transform.position, Quaternion.identity);
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}

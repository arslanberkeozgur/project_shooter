using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    GameObject player; // In order to get the damage of the weapon player.
    ParticleSystem hitEffect; 
    [Tooltip("Set enemy speed towards the player.")]
    [SerializeField] float enemySpeed = 1;
    [Tooltip("Enemy hit points.")]
    [SerializeField] int hitPoints = 10;

    static int playerDamage = 1; // Damage of the player's weapon.


    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.FindGameObjectWithTag("Player");
       hitEffect = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move towards the player.
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, enemySpeed * Time.deltaTime);
    }

    private void OnParticleCollision(GameObject other)
    {
        hitPoints -= playerDamage;

        hitEffect.Play(); // Write a better code for this.

        if (hitPoints <= 0)
        {
            DestroyEnemy();
        }
    }

    public static void setPlayerDamage(int damage) // Player will reach this method.
    {
        Enemy.playerDamage = damage;
    }

    private void DestroyEnemy()
    {
        Destroy(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    GameObject player;
    [Tooltip("Set enemy speed towards the player.")]
    [SerializeField] float enemySpeed = 1;
    [Tooltip("Enemy hit points.")]
    [SerializeField] int hitPoints = 10;

    static int playerDamage;


    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, enemySpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            hitPoints -= playerDamage;
        }
    }

    public static void setPlayerDamage(int damage)
    {
        Enemy.playerDamage = damage;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    GameObject player;
    ParticleSystem hitEffect;
    [Tooltip("Set enemy speed towards the player.")]
    [SerializeField] float enemySpeed = 1;
    [Tooltip("Enemy hit points.")]
    [SerializeField] int hitPoints = 10;

    static int playerDamage;


    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.FindGameObjectWithTag("Player");
       hitEffect = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, enemySpeed * Time.deltaTime);

    }

    private void OnParticleTrigger()
    {
        Debug.Log("Collided.");
        hitPoints -= playerDamage;
        hitEffect.Play();
    }

    public static void setPlayerDamage(int damage)
    {
        Enemy.playerDamage = damage;
    }
}

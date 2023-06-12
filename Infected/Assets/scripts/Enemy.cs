using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;

    public float health = 100f;
    public float delayFactor = 0.01f;

    public float doDamage;

    public Playerscript ps;

    public float timeBetweenAttacks;

    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    
    private void ChasePlayer()
    {
        agent.SetDestination(player.position);

    }

    public void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        if (distance > 1.5f)
        {
            ChasePlayer();
        }

        if(health < 1)
        {
            Destroy(gameObject);
        }  
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Attack());
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StopAllCoroutines();
        }
    }

    public IEnumerator Attack ()
    {
        while (ps.health > 0)
        {
            yield return new WaitForSeconds(1f);
            ps.health -= 10f;
        }
        

    }








}


﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<NavMeshAgent>().SetDestination(player.transform.position);
        /*
         if(player.transform.position == this.transform.position)
         {
            player.GetComponent(Health) -= 1;
         }
         */
    }
}
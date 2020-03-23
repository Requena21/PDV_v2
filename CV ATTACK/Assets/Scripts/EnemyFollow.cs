using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public GameObject player;
    private float dist;
    private Vector3 posJug;
    private Vector3 posEne;
    private int i = 0;
    public int distanciaDam = 3;
    public float damage = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<NavMeshAgent>().SetDestination(player.transform.position);
        Health stats = player.GetComponent<Health>();
        posJug = player.transform.position;
        posEne = this.transform.position;
        dist = Vector3.Distance(posJug, posEne);
         
    }
    private void FixedUpdate()
    {

        Health stats = player.GetComponent<Health>();
        if (dist < distanciaDam)
        {
            i++;
            if (i == 50)
            {
                stats.vida -= damage * GameplayController.instance.dificultad;
                i = 0;
            }   
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public GameObject pickupEffect;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PickUp(other);
        }
    }

    void PickUp(Collider player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        Health stats = player.GetComponent<Health>();
        stats.health = 100f;

        Destroy(gameObject);
    }
}

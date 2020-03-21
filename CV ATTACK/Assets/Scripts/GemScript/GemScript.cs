using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Player")
        {
            gameObject.SetActive(false);
            GameplayController.instance.PlayCollectableSound();
            GameplayController.instance.gems += 1;
        }
    }

}

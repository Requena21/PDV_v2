using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GemScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Player")
        {
            gameObject.SetActive(false);
            //GameplayController.instance.PlayCollectableSound();
            GameplayController.instance.gems += 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}

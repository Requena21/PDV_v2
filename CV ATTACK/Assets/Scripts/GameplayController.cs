using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour
{

    public static GameplayController instance;

    private AudioSource gemAudio;

    public int gems = 0;
    public Text NGems;
    
    void Awake()
    {
        MakeSingleton();

        gemAudio = GetComponent<AudioSource>();

        NGems.text = gems.ToString();
    }

    private void Update()
    {
        NGems.text = gems.ToString();
    }

    void MakeSingleton()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }else if (instance == null)
        {
            instance = this;
        }
    }

    public void PlayCollectableSound()
    {
        gemAudio.Play();
    }

}

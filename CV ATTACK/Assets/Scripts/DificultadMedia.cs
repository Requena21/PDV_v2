using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DificultadMedia : MonoBehaviour
{



    public void JugarNivel2()
    {
        GameplayController.instance.dificultad = 1.1f;
        SceneManager.LoadScene(1);
    }

}


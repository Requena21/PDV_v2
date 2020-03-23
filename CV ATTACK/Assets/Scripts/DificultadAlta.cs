using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DificultadAlta : MonoBehaviour
{
    public void JugarNivel3()
    {
        GameplayController.instance.dificultad = 1.2f;
        SceneManager.LoadScene(1);
    }

}

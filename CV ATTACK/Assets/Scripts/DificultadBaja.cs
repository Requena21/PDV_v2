using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DificultadBaja : MonoBehaviour
{

    

    public void JugarNivel1()
    {
        GameplayController.instance.dificultad = 1;
        SceneManager.LoadScene(1);
    }

    public void SalirDelJuego()
    {
        Debug.Log("Saliste");
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;

    }
}

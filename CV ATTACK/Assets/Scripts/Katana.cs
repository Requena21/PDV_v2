using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katana : MonoBehaviour
{
    //Para saber si se ha cogido o no
    bool pickedUp = false;

    //Animacion
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pickedUp = true;
            Debug.Log("Katana cogida");
        }
    }

    void Update()
    {
        if (pickedUp == true)
        {
            //Posicion del personaje
            Vector3 pos = GameObject.FindGameObjectWithTag("Player").transform.position;
            pos += new Vector3(0.1f, 0f, 0f);

            //Rotacion del personaje
            Vector3 rot = GameObject.FindGameObjectWithTag("Player").transform.forward;
            pos += rot;

            //Asignacion de la posicion
            transform.position = pos;
            
            //Activar la animacion
            if (Input.GetMouseButtonDown(0))
            {
                anim.Play("KatanaAnimation", -1,0f);
            }
        }
    }

    
}
    

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Vida : MonoBehaviour
{

    private TextMeshProUGUI textMesh;
    private float score;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

        textMesh = GetComponent<TextMeshProUGUI>();
        score = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Health stats = player.GetComponent<Health>();
        score = stats.vida;
        textMesh.text = score.ToString();

    }


}

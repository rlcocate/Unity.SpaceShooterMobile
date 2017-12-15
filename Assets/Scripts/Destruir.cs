using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destruir : MonoBehaviour
{
    public float intervalo;

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, intervalo);
        if (JogadorScript.vida <= 0)
        {
            SceneManager.LoadScene("Start");
        }
    }
}
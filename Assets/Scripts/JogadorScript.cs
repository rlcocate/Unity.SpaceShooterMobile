using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JogadorScript : MonoBehaviour
{
    public bool emJogo;
    public static int vida;
    public static int pontos;
    public float velocidade;
    public float limiteEsquerdo, limiteDireito;

    public GameObject explosaoPrefab;
    public Text txtVidas;
    public Text txtPontos;

    void Start()
    {
        vida = 3;
        pontos = 0;
        emJogo = true;
    }

    void Update()
    {
        txtVidas.text = JogadorScript.vida.ToString();
        txtPontos.text = JogadorScript.pontos.ToString();
        Mover();
    }

    void Mover()
    {

        // Mover
        var move_x = Input.GetAxisRaw("Horizontal") * velocidade * Time.deltaTime;
        var move_y = Input.GetAxisRaw("Vertical") * velocidade * Time.deltaTime;
        transform.Translate(move_x, move_y, 0.0f);

        // Wrap
        if (transform.position.x < limiteEsquerdo || transform.position.y > limiteDireito)
        {
            transform.position = new Vector2(transform.position.x * -1, transform.position.y);
        }
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Inimigo")
        {
            vida--;
            Instantiate(explosaoPrefab, transform.position, transform.rotation);
            Destroy(c.gameObject);
            if (vida <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
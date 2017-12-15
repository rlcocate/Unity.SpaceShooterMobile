using UnityEngine;

public class ProjetilScript : MonoBehaviour
{
    public float velocidade;
    public float tempoDeVida;
    public GameObject explosaoPrefab;

    // Use this for initialization
    void Start()
    {
        // Configura tempo de vida do projetil.
        Destroy(gameObject, tempoDeVida);
    }

    // Update is called once per frame
    void Update()
    {
        // Move o projetil.
        transform.Translate(Vector2.up * velocidade * Time.deltaTime);

    }

    void OnCollisionEnter2D(Collision2D c)
    {
        // Destroi o projetil por colisão.
        if (c.gameObject.tag == "Inimigo")
        {
            JogadorScript.pontos += 1;
            Instantiate(explosaoPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(c.gameObject);
        }
    }
}

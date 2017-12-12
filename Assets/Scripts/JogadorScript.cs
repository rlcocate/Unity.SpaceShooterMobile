using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogadorScript : MonoBehaviour {

	public float velocidade;
	public float limiteEsquerdo, limiteDireito;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Mover ();
	}

	void Mover(){

		// Mover
		var move_x = Input.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;
		var move_y = Input.GetAxisRaw ("Vertical") * velocidade * Time.deltaTime;
		transform.Translate(move_x, move_y, 0.0f);

		// Wrap
		if (transform.position.x < limiteEsquerdo || transform.position.y > limiteDireito) {
			transform.position = new Vector2 (transform.position.x * -1, transform.position.y);

		}
	}
}

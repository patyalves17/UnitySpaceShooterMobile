using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogadorScript : MonoBehaviour {

	public int vida;
	public float velocidade;
	public float limiteEsquerdo, limiteDireito;
	public GameObject explosaoPrefab;

	
	// Update is called once per frame
	void Update () {
		print (vida);
		Mover ();
	}

	void Mover(){
		//mover
		float move_x = Input.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;
		float move_y = Input.GetAxisRaw ("Vertical") * velocidade * Time.deltaTime;
		transform.Translate (move_x, move_y, 0.0f);

		//wrap
		if(transform.position.x<limiteEsquerdo || transform.position.x > limiteDireito){
			transform.position = new Vector2 (transform.position.x * -1, transform.position.y);
		}
	}

	void OnCollisionEnter2D(Collision2D c){
		//verifica colisao com o inimigo
		if(c.gameObject.tag == "inimigo"){
			vida--;
			Instantiate (explosaoPrefab, transform.position, transform.rotation);
			Destroy (c.gameObject);
			if(vida <= 0){
				Destroy (gameObject);
			}
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilScript : MonoBehaviour {

	public float velocidade;
	public float tempoDeVida;
	public GameObject explosaoPrefab;

	// Use this for initialization
	void Start () {
		//configurar tempo de vida do projetil
		Destroy(gameObject, tempoDeVida);
	}
	
	// Update is called once per frame
	void Update () {
		//move o projetil
		transform.Translate(Vector2.up * velocidade * Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D c){
		//destroi o projetil por colisao
		if(c.gameObject.tag == "inimigo"){
			Instantiate (explosaoPrefab, transform.position, transform.rotation);
			Destroy (c.gameObject);
			Destroy (gameObject);
		}
	}
}

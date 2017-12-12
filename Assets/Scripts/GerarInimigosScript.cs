using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarInimigosScript : MonoBehaviour {

	public GameObject inimigo;
	public float limiteEsquerdo, limiteDireito;
	public float TempoInicial, TempoFinal;


	IEnumerator Start () {
		//aguarda para criacao de um inimigo
		yield return new WaitForSeconds (Random.Range (TempoInicial, TempoFinal));

		//sorteia posicao em x para instanciar o inimigo
		Vector2 posicao =new Vector2(Random.Range(limiteEsquerdo, limiteDireito), transform.position.y);


		//instancia o inimigo
		Instantiate(inimigo, posicao, transform.rotation);

		//looping
		StartCoroutine(Start());
	}
}

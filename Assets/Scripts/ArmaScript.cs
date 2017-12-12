using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaScript : MonoBehaviour {

	public GameObject projetil;
		
	// Update is called once per frame
	void Update () {
		//Disparo do projetil
		if(Input.GetButtonDown("Jump")){
			Instantiate (projetil, transform.position,transform.rotation);
		}
	}
}

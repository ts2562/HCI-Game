using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour {

	public GameObject Player;
	Vector3 start = new Vector3(-21.0f, -12.5f, 0);
	Vector3 playerPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		playerPos = new Vector3(Player.transform.position.x,Player.transform.position.y,0);
	}

	void OnTriggerEnter2D(Collider2D col){
     	if(col.gameObject.name == "Player"){
     		Player.transform.position = start;
     	}
     }
}

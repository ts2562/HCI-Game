using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
bool isLeft = false;
Vector3 left = new Vector3(-0.2f,0,0);
Vector3 right = new Vector3(0.2f,0,0);
	Vector3 start;

public GameObject Player;
	// Use this for initialization
	void Start () {
		start = transform.position;		
	}
	
	// Update is called once per frame
	void Update () {
		//3 - 30 are the x vals
		if(transform.position.x >= 30f){
			isLeft = true;
		}
		if(transform.position.x <= start.x){
			isLeft = false;
		}
		if(isLeft == false)
			transform.position += right;
		if(isLeft == true)
			transform.position += left;
	}

	void OnTriggerEnter2D(Collider2D col){
     	if(col.gameObject.name == "Player"){
     		Player.transform.position = start;
     	}
  
     }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
bool isLeft = false;
Vector3 left = new Vector3(-0.2f,0,0);
Vector3 right = new Vector3(0.2f,0,0);

Vector3 start = new Vector3(-21.0f, -12.5f, 0);
public GameObject Player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//3 - 30 are the x vals
		if(transform.position.x >= 30f){
			isLeft = true;
		}
		if(transform.position.x <= 3f){
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

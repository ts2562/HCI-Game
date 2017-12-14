using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrenemyScript2 : MonoBehaviour {
	bool isLeft = false;
	Vector3 left = new Vector3(-0.2f,0,0);
	Vector3 right = new Vector3(0.2f,0,0);
	Vector3 start;
	public bool isTouching;
	float jumpThing = 10.28206f;
	public GameObject Player;
	Vector3 EnemyPlayerV;
	// Use this for initialization
	void Start () {
		start = transform.position;		
		EnemyPlayerV = new Vector3(transform.position.x, transform.position.y + 1f, 0f);
		isTouching = false;
	}

	// Update is called once per frame
	
	
	void Update () {
		//3 - 30 are the x vals
		EnemyPlayerV = new Vector3(transform.position.x, transform.position.y + 2f, 0f);
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
		if(isTouching == true){
			Player.transform.position = new Vector3(transform.position.x, Player.transform.position.y, 0f);
		}
		if(Player.transform.position.y > jumpThing){
				isTouching = false;
			}
	}
	void OnCollisionEnter2D(Collision2D col){
     	if(col.gameObject.tag == "Player"){
     		//Player.transform.position = new Vector3(transform.position.x, Player.transform.position.y, 0f);
     		Debug.Log("TEST1");
     		isTouching = true;
     	}
     }
}

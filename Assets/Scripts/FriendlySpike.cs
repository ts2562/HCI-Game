using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlySpike : MonoBehaviour {

	public GameObject Player;
	Vector3 start = new Vector3(-21.0f, -12.5f, 0);
	Vector3 playerPos;
	bool isTouching;
	// Use this for initialization
	void Start () {
		isTouching = false;
	}
	/*
	// Update is called once per frame
	void Update () {
		playerPos = new Vector3(Player.transform.position.x,Player.transform.position.y,0);
		if(isTouching == true){
			float jumpTimer = Time.deltaTime * 120;
			Vector2 curJumpSpeed = new Vector2 (0, 5* jumpTimer * 2 + 15f);
			Player.GetComponent<Rigidbody2D> ().velocity = curJumpSpeed;
			Player.isFalling = true;
		}
	}
*/
	void OnTriggerEnter2D(Collider2D col){
     	if(col.gameObject.name == "Player"){
     		isTouching = true;
     	}
     }
}

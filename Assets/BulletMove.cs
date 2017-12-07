using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {
public GameObject ice1;

	public GameObject Player;
	Vector3 ice1Start = new Vector3(-21.9f, 8.5f, 0);
	Vector3 start = new Vector3(-21.0f, -12.5f, 0);
	//Vector3 playerPos;
	//public AudioSource audio;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//playerPos = new Vector3(Player.transform.position.x,Player.transform.position.y,0);
		transform.position += Vector3.right * 10.0f * Time.deltaTime;
		if(transform.position.x >= 42f){
			transform.position = ice1Start;
		}
		}

	void OnTriggerEnter2D(Collider2D col){
     	if(col.gameObject.name == "Player"){
     		//Destroy(col.gameObject);
     		//ice1.transform.position = ice1Start;
     		//audio.Play();
     		Debug.Log("TRUE");
     		Player.transform.position = start;
     		ice1.transform.position = ice1Start;
     	}
  
     }
}

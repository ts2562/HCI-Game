using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private float speed = 10.0f;
	public Vector2 jumpHeight;
	//public float bounciness = 2.0f;
	public GameObject Life1;
	//public bool colliding;
	// Use this for initialization
	public bool isFalling = false;
	
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A)){
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.D)){
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKeyDown(KeyCode.Space) && !isFalling)  //make a limit to how many times player can jump later
		{

			float jumpTimer = Time.deltaTime * 120;
			Vector2 curJumpSpeed = new Vector2 (0, 5* jumpTimer * 2 + 5f);
			this.GetComponent<Rigidbody2D> ().velocity = curJumpSpeed;
			isFalling = true;

		}
	}

	void OnCollisionEnter2D(){
		isFalling = false;
	}
}

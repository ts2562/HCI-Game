using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementCamera : MonoBehaviour {

	private float speed = 10.0f;
	public Vector2 jumpHeight;
	//public float bounciness = 2.0f;
	public GameObject Life1;
	//public bool colliding;
	// Use this for initialization
	public bool isFalling = false;
	Vector3 start;

	void Start () {
		start = transform.position;		
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A)){
			transform.position += Vector3.left * speed * Time.deltaTime;
			if(transform.position.x < -19 && Camera.main.transform.position.x > 5){
				Camera.main.transform.position +=  Vector3.left * speed * Time.deltaTime;

			}
		}
		if(Input.GetKey(KeyCode.D)){
			transform.position += Vector3.right * speed * Time.deltaTime;
			if (transform.position.x > -33 && Camera.main.transform.position.x < 21.4) {
				Camera.main.transform.position +=  Vector3.right* speed * Time.deltaTime;
			}
		}
		if (Input.GetKeyDown(KeyCode.Space) && !isFalling)  //make a limit to how many times player can jump later
		{

			float jumpTimer = Time.deltaTime * 120;
			Vector2 curJumpSpeed = new Vector2 (0, 5* jumpTimer * 2 + 5f);
			this.GetComponent<Rigidbody2D> ().velocity = curJumpSpeed;
			isFalling = true;

		}
		if(transform.position.y < -20){
			transform.position = start;
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.name == "Goal"){
			Debug.Log("Hi");
			SceneManager.LoadScene (SceneManager.GetSceneAt(0).buildIndex + 1);
		}
		isFalling = false;
	}
}

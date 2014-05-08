using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour {
	public GameObject SpeedBoost;
	public float jumpForce = 10.0f;
	public float Speed = 10.0f;
	public LayerMask whatIsGround;
	public Transform groundCheck;
	bool go = false;
	float act = 10f;
	bool grounded;
	float groundRadius = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//am I on ground?
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);

		//right-left movement
		transform.position = new Vector2 (transform.position.x + Input.GetAxis("Horizontal") * Speed * Time.deltaTime, 
		                                  transform.position.y);
		//jumping
		if (Input.GetKeyDown (KeyCode.UpArrow) && grounded)
			rigidbody2D.AddForce (new Vector2(0,jumpForce));
		if (go == true) {
			act -= Time.deltaTime*10;
			if (act < 0){
				go =  false;
				act = 10.0f;
			}
			
		}

	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject == SpeedBoost){
			Time.timeScale = 3;

			go = true;
	}
	}}

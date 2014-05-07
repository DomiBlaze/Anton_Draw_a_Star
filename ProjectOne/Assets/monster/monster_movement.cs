using UnityEngine;
using System.Collections;

public class monster_movement : MonoBehaviour {

	public float Speed = 10.0f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2 (transform.position.x + Speed * Time.deltaTime, 
		                                  transform.position.y);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Destroy (other.gameObject);
		//creating another earth unit

		//Destroy (gameObject);
		//Debug.Log("something has hit me");
	}


}

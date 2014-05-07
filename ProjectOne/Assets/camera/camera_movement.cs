using UnityEngine;
using System.Collections;

public class camera_movement : MonoBehaviour {
	public float Speed = 10.0f ;
	public GameObject Earth;
	public GameObject Player;
	public float timerSet = 0.1f;
	float position = 0f;
	float timer = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Player != null) {		
						transform.position = new Vector3 (Player.transform.position.x, 
		                                  0f, Player.transform.position.z - 10.0f);
				}
				if (timer < 0) {
						Instantiate (Earth, new Vector3 (position + 10.0f, -4.7f, 0f), gameObject.transform.rotation);
						timer = timerSet;
						position += 2.5f;
						if (Random.value > 0.85f) {
								Instantiate (Earth, new Vector3 (position + 10.0f, 2.35f, 0f), gameObject.transform.rotation);
						}
						if (Random.value > 0.85f) {
								Instantiate (Earth, new Vector3 (position + 10.0f, 0, 0f), gameObject.transform.rotation);
						}
						if (Random.value > 0.85f) {
								Instantiate (Earth, new Vector3 (position + 10.0f, -2.35f, 0f), gameObject.transform.rotation);
						} 
				}
				else
						timer -= Time.deltaTime;
				
						
		}


}

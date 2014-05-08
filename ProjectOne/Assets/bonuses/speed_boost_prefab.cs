using UnityEngine;
using System.Collections;

public class speed_boost_prefab : MonoBehaviour {
	public GameObject SpeedBoost;
	public GameObject Player;
	float lastTime;
	public static bool timer = false;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
		}

	void OnTriggerEnter2D(Collider2D other){
				if (other.gameObject == Player) {
			       
			       Time.timeScale = 3;
				GameObject Monster = GameObject.Find("Monster");
				Monster.GetComponent<shit_code_timer>().up();
			       Destroy (SpeedBoost);
			             

		}
			            
				}
		}


using UnityEngine;
using System.Collections;

public class EnemySpawnSpawner : MonoBehaviour {

	public GameObject shadow;
	public float delay;



	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.CompareTag("Player")) {
			Instantiate(shadow, transform.position, transform.rotation);
			Debug.Log ("Collision Detected");
		}
	}
}

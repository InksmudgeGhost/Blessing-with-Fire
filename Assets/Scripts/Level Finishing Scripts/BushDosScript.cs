using UnityEngine;
using System.Collections;

public class BushDosScript : MonoBehaviour {

	public GameObject dosTheKey;

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.CompareTag ("Weapon")) {
			dosTheKey.SetActive(true);
			Debug.Log ("dosBush");
		}
	}
}

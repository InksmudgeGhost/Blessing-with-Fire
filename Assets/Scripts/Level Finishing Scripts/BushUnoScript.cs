using UnityEngine;
using System.Collections;

public class BushUnoScript : MonoBehaviour {

	public GameObject unoTheKey;

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.CompareTag ("Weapon")) {
			unoTheKey.SetActive(true);
			Debug.Log ("UnoBush");
		}
	}
}

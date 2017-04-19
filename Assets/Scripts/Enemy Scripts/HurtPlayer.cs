﻿using UnityEngine;
using System.Collections;

public class HurtPlayer : MonoBehaviour {

	public int damageToGive;

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.CompareTag ("Player")) {
			other.gameObject.GetComponent<PlayerHealthManager> ().HurtPlayer (damageToGive);
		}
	}
}


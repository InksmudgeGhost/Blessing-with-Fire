﻿using UnityEngine;
using System.Collections;

public class HurtEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag("Enemy")) {
			other.gameObject.SetActive(false);
			Debug.Log ("hiiit");
		}
	}
}

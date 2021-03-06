﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed;
	private Rigidbody2D myRigidBody;

	private Animator anim;

	private bool playerMoving;
	private Vector2 lastMove;


	void Start () {
		anim = GetComponent<Animator> ();
		myRigidBody = GetComponent<Rigidbody2D>();
	}

	void Update () {

		playerMoving = false;

		if (Input.GetAxisRaw ("Horizontal") > 0.5f  || Input.GetAxisRaw("Horizontal") < -0.5f) {
			myRigidBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, myRigidBody.velocity.y);
			lastMove = new Vector2 (Input.GetAxisRaw ("Horizontal"), 0f);
			playerMoving = true;
			//transform.Translate (new Vector3 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
		}

		if (Input.GetAxisRaw ("Vertical") > 0.5f  || Input.GetAxisRaw("Vertical") < -0.5f) {
			myRigidBody.velocity = new Vector2 (myRigidBody.velocity.x, Input.GetAxisRaw ("Vertical") * moveSpeed);
			lastMove = new Vector2 (0f, Input.GetAxisRaw ("Vertical"));
			playerMoving = true;
			//transform.Translate (new Vector3 (0f, Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime, 0f));
		}

		if (Input.GetAxisRaw ("Horizontal") < 0.5f && Input.GetAxisRaw ("Horizontal") > -0.5f) {
			myRigidBody.velocity = new Vector2 (0f, myRigidBody.velocity.y);
		}

		if (Input.GetAxisRaw ("Vertical") < 0.5f && Input.GetAxisRaw ("Vertical") > -0.5f) {
			myRigidBody.velocity = new Vector2 (myRigidBody.velocity.x, 0f);
		}

		anim.SetFloat ("MoveX", Input.GetAxisRaw ("Horizontal"));
		anim.SetFloat ("MoveY", Input.GetAxisRaw ("Vertical"));
		anim.SetBool ("PlayerMoving", playerMoving);
		anim.SetFloat ("LastMoveX", lastMove.x);
		anim.SetFloat ("LastMoveY", lastMove.y);

	}


}


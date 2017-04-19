using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public Transform camTarget;
	public float mspeed;
	Camera mycam;

	// Use this for initialization
	void Start () {
		mycam = GetComponent<Camera> ();

	
	}
	
	// Update is called once per frame
	void Update () {
		mycam.orthographicSize = (Screen.height / 20f / 4f);

		if (camTarget) {
			transform.position = Vector3.Lerp (transform.position, camTarget.position, mspeed) + new Vector3 (0, 0, -10);
		}
	} 
}

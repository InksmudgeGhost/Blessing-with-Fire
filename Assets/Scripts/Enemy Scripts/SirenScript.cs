using UnityEngine;
using System.Collections;

public class SirenScript : MonoBehaviour {

	public float timeLoop;
	public float timeLoopFor;
	private PointEffector2D sirenSinging;

	void Start (){
		sirenSinging = GetComponent<PointEffector2D> ();
		InvokeRepeating("SirenLoop", timeLoop, timeLoopFor);
	}

	void SirenLoop (){
		if (sirenSinging.enabled == true) {
			sirenSinging.enabled = false;
			Debug.Log ("false");
		}

		else{
			if (sirenSinging.enabled == false) {
				sirenSinging.enabled = true;
				Debug.Log ("true");
			}
		}
	}
}

	
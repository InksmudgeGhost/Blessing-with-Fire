using UnityEngine;
using System.Collections;

public class DoorGuardianScripting : MonoBehaviour {

	private float unoKeyValue = 3;
	private float dosKeyValue = 4;

	public Collider2D keyTheFirst;
	public Collider2D keyTheSecond;

	public GameObject theDoor;

	void Start () {
		InvokeRepeating ("DoorChecking", 1, 1);


	}

	void DoorChecking (){
		if (keyTheFirst.enabled == true) {
			unoKeyValue = 5;
		}

		if (keyTheSecond.enabled == true) {
			dosKeyValue = 5;
		}

		if (unoKeyValue == dosKeyValue) {
			theDoor.SetActive (true);
		}

	}


}

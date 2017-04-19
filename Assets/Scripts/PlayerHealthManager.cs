using UnityEngine;
using System.Collections;

public class PlayerHealthManager : MonoBehaviour {

	public int playerMaxiumHealth;
	public int playerCurrentHealth;

	void Start () {
		playerCurrentHealth = playerMaxiumHealth;
	}
	

	void Update () {
		if (playerCurrentHealth <= 0) {
			gameObject.SetActive (false);
		}
	}

	public void HurtPlayer (int damageToGive){
		playerCurrentHealth -= damageToGive; 
	}

	public void SetMaxHealth (){
		playerCurrentHealth = playerMaxiumHealth;
	}
}

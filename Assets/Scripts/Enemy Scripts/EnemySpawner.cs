using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public enum SpawnState {spawning, waiting, counting};

	[System.Serializable]
	public class Wave{
		public Transform enemy;
		public int count;
		public float delay = 1f;
	}

	public Wave[] waves;
	public int nextWave = 0;

	public float timeBetweenWaves = 5f;
	public float waveCountDown; 

	private SpawnState state = SpawnState.counting;

	void Start (){
		waveCountDown = timeBetweenWaves;
	}

	void Update (){


		if (waveCountDown <= 0) {
			if (state != SpawnState.spawning) {
				StartCoroutine (SpawnWave (waves[nextWave]));
			}
		}
		else {
			waveCountDown -= Time.deltaTime;
		}
	}
		


	IEnumerator SpawnWave (Wave _wave){
		state = SpawnState.spawning;

		for (int i = 0; i < _wave.count; i++) {
			SpawnEnemy (_wave.enemy);
			yield return new WaitForSeconds (_wave.delay);
		}

		state = SpawnState.waiting;

		yield break;
	}

	void SpawnEnemy (Transform _enemy){
		Instantiate (_enemy, transform.position, transform.rotation);
	}
}

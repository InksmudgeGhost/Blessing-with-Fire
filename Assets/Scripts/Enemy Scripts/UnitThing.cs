using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class UnitThing : MonoBehaviour {


	public Transform target;
	public float speed;
	Vector3[] path;
	int targetIndex;
	public Vector3 targetOldPosition;


	private GameObject thePlayer;


	void Start() {
		target = GameObject.FindWithTag("Player").transform;


	}

	void Update () {
		if (Vector3.Distance (targetOldPosition, target.position) > 1) {
			PathRequestManager.RequestPath (transform.position, target.position, OnPathFound);
			targetOldPosition = target.position;

		}
			
	
		///player reload stuff

	}

	IEnumerator TryingtoWork () {
		yield return new WaitForSeconds (5f);
	}





	public void OnPathFound(Vector3[] newPath, bool pathSuccessful) {
		if (pathSuccessful) {
			path = newPath;
			targetIndex = 0;
			StopCoroutine("FollowPath");
			StartCoroutine("FollowPath");
		}
	}

	IEnumerator FollowPath() {
		Vector3 currentWaypoint = path[0];
		while (true) {
			if (transform.position == currentWaypoint) {
				targetIndex ++;
				if (targetIndex >= path.Length) {
					targetIndex = 0;
					path = new Vector3[0];
					yield break;
				}
				currentWaypoint = path[targetIndex];
			}

			transform.position = Vector3.MoveTowards(transform.position,currentWaypoint,speed * Time.deltaTime);
			yield return null;

		}
	}

	public void OnDrawGizmos() {
		if (path != null) {
			for (int i = targetIndex; i < path.Length; i ++) {
				Gizmos.color = Color.black;
				Gizmos.DrawCube(path[i], Vector3.one);

				if (i == targetIndex) {
					Gizmos.DrawLine(transform.position, path[i]);
				}
				else {
					Gizmos.DrawLine(path[i-1],path[i]);
				}
			}
		}
	}


		

}
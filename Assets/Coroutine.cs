using UnityEngine;
using System.Collections;

public class Coroutine : MonoBehaviour {


	[SerializeField] float timerTime;
	// Use this for initialization

	public void StopTimer() {
		StopCoroutine ("RunTimer");
	}

	public void StartTimer() {
		StopTimer ();
		StartCoroutine ("RunTimer");
	}

	public void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private IEnumerator RunTimer() {
		float timer = 0;
		while (timer < timerTime) {
			timer += Time.deltaTime;
			Debug.Log (timer);

			yield return null;
		}
			
		Debug.Log ("einde");
	}
}

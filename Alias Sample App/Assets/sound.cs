using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour {
	AudioSource clip;
	// Use this for initialization
	void Start () {
		clip = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	// Is called everytime Mouse is pressed Down
	void OnMouseDown(){
		StartCoroutine (Wait ());
	}
	IEnumerator Wait(){
		clip.Play ();
		yield return new WaitForSeconds(7);
		clip.Stop ();
	}
}

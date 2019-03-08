using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide_show_object : MonoBehaviour {
	public Renderer rend;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
	}
	
	// Is called everytime Mouse is pressed Down
	void OnMouseDown(){
		rend.enabled = !(rend.enabled);
	}
}

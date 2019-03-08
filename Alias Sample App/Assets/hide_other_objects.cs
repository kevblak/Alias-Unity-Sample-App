using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide_other_objects : MonoBehaviour {
	public GameObject cube, sphere, capsule;
	// Use this for initialization
	void Start () {
		cube = GameObject.Find ("Cube");
		sphere = GameObject.Find ("Sphere");
		capsule = GameObject.Find ("Capsule");
	}
	
	// Is called everytime Mouse is pressed Down
	void OnMouseDown(){
		if (this.name == "Sphere") {														//checks if object the script is applied to is the Sphere
			if (cube.activeInHierarchy == true && capsule.activeInHierarchy == true) {
				cube.gameObject.SetActive (false);
				capsule.gameObject.SetActive (false);
			} else {
				cube.gameObject.SetActive (true);
				capsule.gameObject.SetActive (true);
			}
		}
		if (this.name == "Cube") {															//checks if object the script is applied to is the Cube
			if (sphere.activeInHierarchy == true && capsule.activeInHierarchy == true) {
				sphere.gameObject.SetActive (false);
				capsule.gameObject.SetActive (false);
			} else {
				sphere.gameObject.SetActive (true);
				capsule.gameObject.SetActive (true);
			}
		}
		if (this.name == "Capsule") {														//checks if object the script is applied to is the Capsule
			if (cube.activeInHierarchy == true && sphere.activeInHierarchy == true) {
				cube.gameObject.SetActive (false);
				sphere.gameObject.SetActive (false);
			} else {
				cube.gameObject.SetActive (true);
				sphere.gameObject.SetActive (true);
			}
		}
	}
}

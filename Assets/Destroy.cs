using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	private GameObject unitychanObject;
	// Use this for initialization
	void Start () {
		unitychanObject = GameObject.Find ("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.z + 3 < unitychanObject.transform.position.z) {
			Destroy (gameObject);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Start");
		var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowKeysMovement : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update()
	{
		int speed = 10;
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(Vector3.back * speed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.Space)) 
		{
			transform.Translate (Vector3.up * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.V)) 
		{
			transform.Translate (Vector3.down * speed * Time.deltaTime);
		}
	}
}

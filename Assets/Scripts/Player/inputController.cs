using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputController : MonoBehaviour {

	[HideInInspector] public float x;
	[HideInInspector] public float y;	
	// Update is called once per frame
	void Update () {
		this.x = Input.GetAxis("Horizontal");
		this.y = Input.GetAxis("Vertical");
	}
}

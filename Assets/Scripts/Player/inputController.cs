﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputController : MonoBehaviour {

	[HideInInspector] public float x;
	[HideInInspector] public float y;
	[HideInInspector] public Vector2 facedir = new Vector2(0,-1f);	
	// Update is called once per frame
	void Update () {
		this.x = Input.GetAxis("Horizontal");
		this.y = Input.GetAxis("Vertical");

		getFace();

	}

	private void getFace()
	{
		if( x!= 0 || y != 0 )
		{
			facedir.x = x;
			facedir.y = y;
		}
	}
}

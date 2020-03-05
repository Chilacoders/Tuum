using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
	[SerializeField] private float speed; // Speed
	private Rigidbody2D rigid; // Physics
	private inputController input; // Input
	void Start () {
		// Get all components
		rigid = GetComponent<Rigidbody2D>();
		input = GetComponent<inputController>();
	}
	
	private void FixedUpdate()
	{
		Vector2 force = new Vector2(input.x,input.y) * speed;
		rigid.velocity = force;

	}


	// Update is called once per frame
	void Update () {
		
	}
}

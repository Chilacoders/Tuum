using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
	[SerializeField] private float speed; // Speed
	private Rigidbody2D rigid; // Physics
	private inputController input; // Input
	private Animator anim;
	private int rHash; // Running Hash


	void Start () {
		// Get all components
		rigid = GetComponent<Rigidbody2D>();
		input = GetComponent<inputController>();
		anim = GetComponent<Animator>();
		rHash = Animator.StringToHash("isRunning");
	}
	
	private void FixedUpdate()
	{
		Vector2 force = new Vector2(input.x,input.y) * speed;
		rigid.velocity = force;

	}

	private void SetAnimation()
	{
		if(input.x != 0|| input.y != 0) anim.SetBool(rHash,true);
		else anim.SetBool(rHash,false);

		anim.SetFloat("x",input.facedir.x);
		anim.SetFloat("y",input.facedir.y);
	}
	// Update is called once per frame
	void Update () {
		SetAnimation();
	}
}

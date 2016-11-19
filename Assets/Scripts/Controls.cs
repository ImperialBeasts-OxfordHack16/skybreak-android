using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {
	public Rigidbody2D rb;
	public float movespeed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Touch touch in Input.touches)
		{
			rb.velocity = new Vector2(movespeed, rb.velocity.y);
		}
	}
}

using UnityEngine;
using System.Collections;

public class Raquete : MonoBehaviour
{

	public float velocidade = 5f;
	private float _input;
	private Rigidbody2D _rb;

	// Use this for initialization
	void Start ()
	{
		_rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		_input = Input.GetAxis ("Horizontal");
	}
	
	void FixedUpdate ()
	{
		_rb.velocity = new Vector2 (_input * velocidade, 0);
	}
}

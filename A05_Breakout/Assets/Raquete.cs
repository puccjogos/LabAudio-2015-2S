using UnityEngine;
using System.Collections;

public class Raquete : MonoBehaviour
{
	public float velocidade = 5f;
	private float _input;
	private Rigidbody2D _rb;

	void Start ()
	{
		_rb = GetComponent<Rigidbody2D> ();
	}
	
	void Update ()
	{
		// captura o input do jogador
		_input = Input.GetAxis ("Horizontal");
	}
	
	void FixedUpdate ()
	{
		// muda a velocidade do Rigidbody2D
		_rb.velocity = new Vector2 (_input * velocidade, 0);
	}
}










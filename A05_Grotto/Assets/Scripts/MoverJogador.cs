using UnityEngine;
using System.Collections;

public class MoverJogador : MonoBehaviour
{
	public float velocidade;
	public Animator anim;
	private float _input;
	private Rigidbody2D _rb;
	public Transform visual;
	public float pulo;
	
	void Start ()
	{
		_rb = GetComponent<Rigidbody2D> ();
	}
	
	void Update ()
	{
		_input = Input.GetAxis ("Horizontal");
		if (_input != 0) {
			visual.localScale = new Vector3 (Mathf.Sign (_input), 1, 1);
		}
		if (Input.GetButtonDown ("Jump") && Mathf.Abs (_rb.velocity.y) < 0.1f) {
			_rb.velocity += new Vector2 (0, pulo);
		}
	}
	
	void FixedUpdate ()
	{
		_rb.velocity = new Vector2 (_input * velocidade, _rb.velocity.y);
		anim.SetFloat ("velocidadeX", Mathf.Abs (_rb.velocity.x));
		anim.SetFloat ("velocidadeY", Mathf.Abs (_rb.velocity.y));
	}
}

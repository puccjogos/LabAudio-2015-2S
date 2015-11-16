using UnityEngine;
using System.Collections;

public class SeguirAlvo : MonoBehaviour
{
	public Transform alvo;
	public float fator;
	private Vector3 _offset;

	// Use this for initialization
	void Start ()
	{
		_offset = transform.position - alvo.position;
	}
	
	void Update ()
	{
		Vector3 velocidade = Vector3.zero;
		transform.position = Vector3.Lerp (
			transform.position, 
			alvo.position + _offset,
			Time.smoothDeltaTime * fator);	
	}
}

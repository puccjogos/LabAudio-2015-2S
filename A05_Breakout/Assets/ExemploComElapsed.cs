using UnityEngine;
using System.Collections;

public class ExemploComElapsed : MonoBehaviour
{

	void Start ()
	{
	
	}
	
	void FixedUpdate ()
	{
		transform.position += 
			new Vector3 (1f / 60f, 0, 0);
	}
}

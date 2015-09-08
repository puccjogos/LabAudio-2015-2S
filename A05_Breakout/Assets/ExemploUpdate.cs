using UnityEngine;
using System.Collections;

public class ExemploUpdate : MonoBehaviour
{

	void Start ()
	{
	
	}
	
	void Update ()
	{
		transform.position += 
			new Vector3 (1f / 60f, 0, 0);
	}
}

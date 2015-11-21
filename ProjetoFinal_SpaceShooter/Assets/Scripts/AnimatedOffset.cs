using UnityEngine;
using System.Collections;

public class AnimatedOffset : MonoBehaviour
{

	public Vector2 offsetSpeed;
	Renderer rend;

	void Start ()
	{
		rend = GetComponent<Renderer> ();
	}
	
	void Update ()
	{
		rend.material.SetTextureOffset ("_MainTex", rend.material.mainTextureOffset + offsetSpeed * Time.deltaTime);
	}
}

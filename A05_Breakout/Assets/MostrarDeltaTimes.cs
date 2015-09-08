using UnityEngine;
using System.Collections;

public class MostrarDeltaTimes : MonoBehaviour
{	
	void FixedUpdate ()
	{
		print ("FIXED_UPDATE");
	}
	
	void Update ()
	{
		print ("UPDATE");
	}
	
	void LateUpdate ()
	{
		print ("LATE_UPDATE");
	}
}

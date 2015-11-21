using UnityEngine;
using System.Collections;

public class AtirarJogador : MonoBehaviour
{	
	public KeyCode tecla;
	
	void Update()
	{
		if (Input.GetKeyDown(tecla))
		{
			BroadcastMessage("Disparar");
		} 
	}
}

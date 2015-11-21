using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour
{
	public float tempoVida;
	
	void Update()
	{
		tempoVida -= Time.deltaTime;
		if (tempoVida < 0)
		{
			Destroy(gameObject);
		}	
	}
}

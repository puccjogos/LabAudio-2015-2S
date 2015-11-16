using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class ControlarEfeito : MonoBehaviour
{
	public AudioMixer mixer;

	void Start()
	{
	
	}
	
	void Update()
	{
		var posX = transform.position.x;
		var cutoff = Mathf.Clamp(22000 - posX * 1000, 200, 22000);
		mixer.SetFloat("cutoffGeral", cutoff);
	}
}

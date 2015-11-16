using UnityEngine;
using System.Collections;
using UnityEngine.Audio; // importando a parte de audio do scripting

public class TrocarSnapshot : MonoBehaviour
{
	public AudioMixerSnapshot snapPadrao, snapMagica;
	
	void OnTriggerEnter2D()
	{
		snapMagica.TransitionTo(1);
	}
	
	void OnTriggerExit2D()
	{
		snapPadrao.TransitionTo(1);
	}
}

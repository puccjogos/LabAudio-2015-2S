using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class LigarMenu : MonoBehaviour
{

	public bool menuLigado = false;
	public AudioMixerSnapshot snapMenu, snapIngame;
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			menuLigado = !menuLigado;
			if (menuLigado)
			{
				snapMenu.TransitionTo(1f);
			} else
			{
				snapIngame.TransitionTo(1f);
			}
		}
	}
}

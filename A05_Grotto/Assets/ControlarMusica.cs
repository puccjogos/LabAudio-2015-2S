using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class ControlarMusica : MonoBehaviour
{
	public AudioMixer mixer;
	
	public void MudarMusica(float volume)
	{
		mixer.SetFloat("volMusica", volume);
	}
}

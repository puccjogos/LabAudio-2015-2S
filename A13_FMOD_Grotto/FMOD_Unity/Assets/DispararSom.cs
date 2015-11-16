using UnityEngine;
using System.Collections;

public class DispararSom : MonoBehaviour
{
	public AudioSource audio;
	public bool aleatorizarVolume;
	public float margemVolume;
	public float margemPitch;
	
	public void Tocar (AudioClip clip)
	{
		if (aleatorizarVolume) {
			audio.pitch = 0.8f + Random.value * margemPitch;
			audio.PlayOneShot (clip, 
               audio.volume + Random.value * margemVolume);
		} else {
			audio.PlayOneShot (clip);
		}
		
	}
}

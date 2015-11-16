using UnityEngine;
using System.Collections;

public class ControlarSons : MonoBehaviour
{
	private AudioSource _audio;
	public AudioClip somPulo;
	public AudioClip somQueda;

	void Start ()
	{
		_audio = GetComponent<AudioSource> ();
	}

	void SomPulo ()
	{
		// tocar som do pulo
		_audio.PlayOneShot (somPulo);
	}
	
	void SomQueda ()
	{
		// tocar som da queda
		_audio.PlayOneShot (somQueda);
	}
}

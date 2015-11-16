using UnityEngine;
using System.Collections;

public class DispararSomFMOD : MonoBehaviour
{
	public void Tocar(string path)
	{
		FMOD_StudioSystem.instance.PlayOneShot(path, transform.position);
	}
}

using UnityEngine;
using System.Collections;

public class ControlarMusicaFMOD : MonoBehaviour
{
	FMOD.Studio.EventInstance eventoMusica;

	void Start()
	{
		eventoMusica = FMOD_StudioSystem.instance.GetEvent("event:/Musica_02");		
		eventoMusica.start();
	}
	
	void Update()
	{
		float intensidade = Mathf.Clamp(transform.position.x * 2f, 0f, 100f);
		eventoMusica.setParameterValue("Intensidade", intensidade);
	}
	
	void OnDestroy()
	{
		eventoMusica.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
		eventoMusica.release();
	}
	
	public void MudarSaude(float valor)
	{
		eventoMusica.setParameterValue("Saude", valor);
	}
}

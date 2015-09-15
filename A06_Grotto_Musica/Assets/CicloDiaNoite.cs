using UnityEngine;
using System.Collections;

public class CicloDiaNoite : MonoBehaviour
{
	public Gradient cores;
	public AnimationCurve fadeIn, fadeOut;
	public float tempoTotal;
	private float _timer, _timerFadeIn, _timerFadeOut;
	public AudioSource musicaDiurna, musicaNoturna;
	public bool _emTransicao = false;
	

	void Start ()
	{
		_timer = 0;
	}
	
	void Update ()
	{
		_timer += Time.deltaTime;
		_timerFadeIn += Time.deltaTime;
		_timerFadeOut += Time.deltaTime;
		if (_timer > tempoTotal) {
			_timer = 0;
		}
		float fracao = _timer / tempoTotal;
		Camera.main.backgroundColor = cores.Evaluate (fracao);
		/* TRANSICAO CORTE-SECO
		if (fracao > 0.25f && audioMusica.clip != musicaDiurna) {
			audioMusica.Stop ();
			audioMusica.clip = musicaDiurna;
			audioMusica.Play ();
		}
		*/
		if (_timer > 1f) {
			if (_emTransicao == false) {
				_timerFadeIn = 0;
				_timerFadeOut = 0;
				_emTransicao = true;
				musicaDiurna.Play ();
			}
			musicaDiurna.volume = fadeIn.Evaluate (_timerFadeIn);	
			musicaNoturna.volume = fadeOut.Evaluate (_timerFadeOut);
		}
		
		
	}	
}






















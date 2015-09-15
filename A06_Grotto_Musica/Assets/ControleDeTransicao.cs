using UnityEngine;
using System.Collections;

public class ControleDeTransicao : MonoBehaviour
{
	public AnimationCurve fadeIn, fadeOut;
	public float duracaoFadeIn, duracaoFadeOut;
	private float _timerFadeIn, _timerFadeOut;
	public bool emFadeIn, emFadeOut;
	public AudioSource[] audios;
	private int _atual;

	public void DispararFadeIn (int fonte)
	{
		emFadeIn = true;
		_atual = fonte;
		_timerFadeIn = 0;
		audios [_atual].Play ();
	}
	
	public void DispararFadeOut (int fonte)
	{
		emFadeOut = true;
		_atual = fonte;
		_timerFadeOut = 0;
		audios [_atual].Play ();
	}
	
	void Update ()
	{
		if (emFadeIn) {
			_timerFadeIn += Time.deltaTime;
			audios [_atual].volume = fadeIn.Evaluate (_timerFadeIn / duracaoFadeIn);
			if (_timerFadeIn > duracaoFadeIn) {
				emFadeIn = false;
			}
		} else {
			_timerFadeOut += Time.deltaTime;
			audios [_atual].volume = fadeOut.Evaluate (_timerFadeOut / duracaoFadeOut);
			if (_timerFadeOut > duracaoFadeOut) {
				emFadeOut = false;
			}
		}
	}
}

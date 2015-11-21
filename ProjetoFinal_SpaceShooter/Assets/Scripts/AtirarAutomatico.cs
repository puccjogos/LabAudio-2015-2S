using UnityEngine;
using System.Collections;

public class AtirarAutomatico : MonoBehaviour
{
	private Inimigo _inimigo;
	private float _intervalo, _timer;

	void Start()
	{
		_inimigo = GetComponent<Inimigo>();
	}
	
	void Update()
	{
		_timer -= Time.deltaTime;
		if (_timer < 0)
		{
			BroadcastMessage("Disparar");
			_timer = Random.Range(
				_inimigo.infos [_inimigo.tipo].freqMinTiro, 
				_inimigo.infos [_inimigo.tipo].freqMaxTiro);
		}
	}
}

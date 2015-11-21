using UnityEngine;
using System.Collections;

public class GeradorInimigos : MonoBehaviour
{
	public AnimationCurve curvaTipo;
	public AnimationCurve curvaFrequencia;
	
	public float fatorTempo = 20f;
	public float timerProximo = 0;
	
	public Inimigo prefabInimigo;
	
	void Update()
	{
		timerProximo -= Time.deltaTime;
		if (timerProximo < 0)
		{
			var posX = Random.Range(-2f, 2f);
			var pos = transform.position;
			pos.x = posX;
			var inimigo = Instantiate(prefabInimigo, pos, Quaternion.identity) as Inimigo;
			inimigo.tipo = (curvaTipo.Evaluate(Time.realtimeSinceStartup / fatorTempo) < Random.value) ? 0 : 1;
			timerProximo = Random.Range(2f, 3f) * curvaFrequencia.Evaluate(Time.realtimeSinceStartup / fatorTempo);
		}
	}
}

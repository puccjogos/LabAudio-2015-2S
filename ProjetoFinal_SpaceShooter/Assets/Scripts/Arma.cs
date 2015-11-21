using UnityEngine;
using System.Collections;

public class Arma : MonoBehaviour
{
	public Bala prefabBala;
	public float velocidade;
	private float tempoUltimoTiro;
	public float intervaloTiro;

	void Start()
	{
		tempoUltimoTiro = 0;
	}
	
	void Update()
	{
		tempoUltimoTiro -= Time.deltaTime;
	}
	
	void Disparar()
	{
		if (tempoUltimoTiro <= 0)
		{
			var bala = Instantiate(prefabBala, transform.position, transform.rotation) as Bala;
			bala.GetComponent<Rigidbody2D>().velocity = new Vector2(0, velocidade);
			tempoUltimoTiro = intervaloTiro;
		}
	}
}

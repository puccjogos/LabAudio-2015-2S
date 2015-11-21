using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour
{
	public float velocidade;
	public int pontos = 1;
	public float timeOut = 15;
	
	void Start()
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2(0, -SpaceShooter.VelocidadeBase());
		Destroy(gameObject, timeOut);
	}
	
	void OnTriggerEnter2D(Collider2D outro)
	{
		if (outro.CompareTag("NaveJogador"))
		{
			Debug.Log("Coletar powerup");
			SpaceShooter.AdicionarPontos(pontos);
			Destroy(gameObject);
		}
	}
}

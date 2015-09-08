using UnityEngine;
using System.Collections;

public class Bola : MonoBehaviour
{
	public float velocidade;
	public float incrementoVelocidade;
	private Rigidbody2D _rb;

	void Start ()
	{
		// referencia o Rigidbody2D e cria veloccidade inicial
		_rb = GetComponent<Rigidbody2D> ();
		_rb.velocity = Vector2.one * velocidade;
	}
	
	void Update ()
	{
		// checa se a bola esta em um Y menor que a borda inferior
		// da tela
		if (transform.position.y < -20f) {
			Jogo.i.SendMessage ("GameOver");
			Destroy (gameObject);
		}
	}
	
	void OnCollisionEnter2D (Collision2D colisao)
	{
		// trata das colisoes com a raquete, para ter escolhas
		if (colisao.gameObject.name == "Raquete") {
			Vector2 novaVelocidade = _rb.velocity;
			if (_rb.velocity.x > 0 &&
				transform.position.x < colisao.transform.position.x) {
				novaVelocidade.x *= -1;
			}
			if (_rb.velocity.x < 0 &&
				transform.position.x > colisao.transform.position.x) {
				novaVelocidade.x *= -1;
			}
			_rb.velocity = novaVelocidade;
		}
		// trata das colisoes com blocos
		if (colisao.gameObject.CompareTag ("Bloco")) {
			Jogo.i.SendMessage ("ChecarVitoria");
			Destroy (colisao.gameObject);
			_rb.velocity *= incrementoVelocidade;
		}
	}
}

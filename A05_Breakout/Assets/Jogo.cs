using UnityEngine;
using System.Collections.Generic;

public class Jogo : MonoBehaviour
{
	public Transform prefabBloco;
	public int colunas, linhas;
	public List<Transform> blocos;
	public Transform posicaoInicial;
	public static Jogo i;

	void Awake ()
	{
		// semi-singleton para permitir envio de mensagens
		i = this;
		// instanciacao dos blocos
		blocos = new List<Transform> ();
		for (var c = 1; c < colunas; c++) {
			for (var l = 1; l < linhas; l++) {
				Transform novoBloco = Instantiate (
					prefabBloco,
					posicaoInicial.position + new Vector3 (c * 3.5f, l * -2f),
					Quaternion.identity) as Transform;
				blocos.Add (novoBloco);
			}
		}
	}
	
	// disparada pela Bola
	void ChecarVitoria ()
	{
		// retira todos os blocos destruidos da lista
		blocos.RemoveAll (b => b == null);
		if (blocos.Count == 0) {
			print ("Ganhou");
		}
	}
	
	// disparada pela Bola
	void GameOver ()
	{
		print ("Gameover");
	}
}

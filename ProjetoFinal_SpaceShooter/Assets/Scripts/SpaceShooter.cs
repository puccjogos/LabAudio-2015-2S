using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpaceShooter : MonoBehaviour
{
	private static SpaceShooter i;
	public int score;
	public PowerUp prefabPowerUp;
	public float velocidadeBase;
	
	[Header("GUI")]
	public Text
		txtScore;
	
	void Awake()
	{
		if (i == null)
		{
			i = this;
			DontDestroyOnLoad(this.gameObject);
		} else
		{
			Destroy(this.gameObject);
		}
	}
	
	void Start()
	{
		score = 0;
	}
	
	void Update()
	{
		if (Application.loadedLevelName == "MenuInicial")
		{
			if (Input.GetButtonDown("Jump"))
			{
				Application.LoadLevel(1);
			}
		}
		if (Application.loadedLevelName == "GameOver")
		{
			if (Input.GetButtonDown("Jump"))
			{
				i.score = 0;
				i.txtScore.text = i.score.ToString();
				i.velocidadeBase = 1f;
				Application.LoadLevel(0);
			}
		}
	}
	
	public static void AdicionarPontos(int pontos)
	{
		GameObject.Find("BG").GetComponent<AnimatedOffset>().offsetSpeed = new Vector2(0, i.velocidadeBase * 1.5f);
		i.score += pontos;
		i.velocidadeBase += pontos * (2f) * Time.deltaTime;
		i.txtScore.text = i.score.ToString();
	}
	
	public static void CriarPowerUp(Vector3 posicao)
	{
		Instantiate(i.prefabPowerUp, posicao, Quaternion.identity);
	}
	
	public static void AtivarGameOver()
	{
		Debug.Log("Game Over.");
		Application.LoadLevel(2);
	}
	
	public static float VelocidadeBase()
	{
		return i.velocidadeBase;
	}
	
	public static float Score()
	{
		return i.score;
	}
}

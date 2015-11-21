using UnityEngine;
using System.Collections;

[CreateAssetMenu()]
public class InimigoInfo : ScriptableObject
{
	public Sprite visual;
	public int saude;
	public float velocidadeY, velocidadeX;
	public float freqMinTiro, freqMaxTiro;
}
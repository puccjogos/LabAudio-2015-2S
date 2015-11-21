using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CarregarScore : MonoBehaviour
{
	void Start()
	{
		GetComponent<Text>().text = "seu score foi\n" + SpaceShooter.Score().ToString();
	}
}

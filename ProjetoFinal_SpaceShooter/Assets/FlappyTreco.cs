using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FlappyTreco : MonoBehaviour
{
	private string score;
	IEnumerator Start()
	{
		score = "";
		WWW www = new WWW("http://flappy-treco.herokuapp.com/score");
		yield return www;
		score = www.text;
	}
	
	void Update()
	{
		GetComponent<Text>().text = score;
	}
}

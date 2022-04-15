using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedGoalDetection : MonoBehaviour
{
	public static int redScore = 0;
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "SoccerBall")
		{
			redScore += 1;
			SceneManager.LoadScene("SampleScene");

		}
	}
}

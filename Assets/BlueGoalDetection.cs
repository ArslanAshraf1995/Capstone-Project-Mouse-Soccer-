using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlueGoalDetection : MonoBehaviour
{
	public static int blueScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

	// Update is called once per frame
	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "SoccerBall")
		{
			blueScore += 1;
			SceneManager.LoadScene("SampleScene");

		}
	}
}

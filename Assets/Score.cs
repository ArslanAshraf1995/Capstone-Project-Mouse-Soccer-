using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text blueScore;
    public Text redScore;
    public Text yourTurn;
    public EnemyAI yourMove;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        blueScore.text = "Goal: " + BlueGoalDetection.blueScore;
        redScore.text = "Goal: " + RedGoalDetection.redScore;
        if(yourMove.playerTurn == true)
		{
            yourTurn.text = "Your Turn";
		}
		else
		{
            yourTurn.text = "Enemy Turn";
		}
    }
}

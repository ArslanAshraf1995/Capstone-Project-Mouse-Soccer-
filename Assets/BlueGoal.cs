using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BlueGoal : MonoBehaviour
{
    public Text blueGoals;
    public Text redGoals;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        blueGoals.text = "Blue Goals:" + BlueGoalDetection.blueScore;
        redGoals.text = "Red Goals:" + RedGoalDetection.redScore;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyAI : MonoBehaviour
{
    public GameObject[] enemyPlayer;
    public Transform soccerBall;
    private Vector3 direction;
    private float smallestDistance = 2f;
    private float distance;
    private int k;
    public static Rigidbody rb;
    private bool isMoving;
    public float speed = 10;
    public bool playerTurn;
    public bool forcedApplied;
    // Start is called before the first frame update

    void Start()
    {
        InvokeRepeating("EnemyMovement", 3, 1);

    }

    
    
    void EnemyMovement()
	{
        for (int i = 0; i < enemyPlayer.Length; i++)
        {

            distance = Vector3.Distance(enemyPlayer[i].transform.position.normalized, soccerBall.position.normalized);
            if (distance < smallestDistance)
            {
                smallestDistance = distance;
                k = i;
            }


        }



        if (!isMoving && playerTurn == false)
        {

            direction = soccerBall.position - enemyPlayer[k].transform.position;
            rb = enemyPlayer[k].GetComponent<Rigidbody>();
            rb.AddForce(direction * distance * speed, ForceMode.Impulse);
            forcedApplied = true;
            isMoving = true;


        }
        if (rb.IsSleeping() && forcedApplied == true)
        {

            playerTurn = true;
            isMoving = false;
            forcedApplied = false;
        }

        Debug.Log(playerTurn);
    }

}

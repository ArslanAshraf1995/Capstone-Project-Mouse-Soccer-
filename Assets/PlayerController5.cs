using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController5 : MonoBehaviour
{
    private Vector3 mousePosition;
    private Vector3 direction;
    private float angle;
    private Rigidbody rb;
    public float speed = 10;
    private bool isMoving;
    private float distance;
    private bool playerActivate;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == "Player5" && Input.GetKey(KeyCode.Mouse1))
            {
                playerActivate = true;
            }
            if ((hit.transform.name == "Player" || hit.transform.name == "Player2" || hit.transform.name == "Player3"
                || hit.transform.name == "Player4") && Input.GetKey(KeyCode.Mouse1))
            {
                playerActivate = false;
            }

        }
        if (playerActivate)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.y = 0;
            direction = mousePosition - transform.position;
            direction.y = 0;
            angle = Vector3.Angle(direction, transform.position);

            distance = Vector3.Distance(transform.position.normalized, mousePosition.normalized);

            if (distance > 1)
            {
                distance = 1;
            }
            transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
        }




        

        if (Input.GetKey(KeyCode.Mouse0) && !isMoving && playerActivate)
        {
            rb.AddForce(direction * distance * speed, ForceMode.Impulse);
            isMoving = true;
            playerActivate = false;
        }
        if (rb.velocity == new Vector3(0, 0, 0))
        {
            isMoving = false;

        }

    }
}

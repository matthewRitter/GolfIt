using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArrow : MonoBehaviour
{
    public bool isMoving;
    public float xAngle;
    public float yAngle;
    public GameObject golfBall;
    public Rigidbody ball;
    public bool firstRun = true;


    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
        ball = golfBall.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!(isMoving))
        {
            Quaternion directionToFace = gameObject.transform.rotation;

            if (Input.GetKey("w") || (Input.GetKey("up")))
            {
                xAngle -= .5f;
            }
            if (Input.GetKey("a") || (Input.GetKey("left")))
            {
                yAngle -= .5f;
            }
            if (Input.GetKey("s") || (Input.GetKey("down")))
            {
                xAngle += .5f;
            }
            if (Input.GetKey("d") || (Input.GetKey("right")))
            {
                yAngle += .5f;
            }

            golfBall.transform.rotation = Quaternion.Euler(xAngle, yAngle, 0);
        }
    }




}

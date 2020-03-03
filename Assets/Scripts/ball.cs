using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public int maxPower;
    public int minPower;
    public int power;

    private Rigidbody golfBall;

    public bool isMoving;

    private bool increasing;
    private bool powerChanging;
    private Club putter;

    public int yAngle;
    public int xAngle;





    // Start is called before the first frame update
    void Start()
    {
        golfBall = gameObject.GetComponent<Rigidbody>();
        putter = new Club();
    }

    // Update is called once per frame
    void Update()
    {
        if (!(isMoving))
        {

            if (Input.GetKey("w"))
            {
                yAngle++;
            }
            if (Input.GetKey("a"))
            {
                xAngle--;
            }
            if (Input.GetKey("s"))
            {
                yAngle++;
            }
            if (Input.GetKey("d"))
            {
                xAngle--;
            }





            if ((Input.GetKeyDown("space")) && !(powerChanging))
            {
                powerChanging = true;
                StartCoroutine(changePower());
            }
            else if ((Input.GetKeyDown("space")) && (powerChanging))
            {
                powerChanging = false;
            }

        }
    }

    private void StartCoRoutine(IEnumerator enumerator)
    {
        throw new NotImplementedException();
    }

    private IEnumerator changePower()
    {
        while (powerChanging)
        {
            if (increasing)
            {
                if (power + 1 > maxPower)
                {
                    power-= 5;
                    increasing = false;
                }
                else
                {
                    power+= 5;
                }
            }
            else
            {
                if (power - 1 < minPower)
                {
                    power+= 5;
                    increasing = true;
                }
                else
                {
                    power-= 5;
                }
            }
            yield return new WaitForSeconds(.001f);
        }
        powerChanging = false;
        StartCoroutine(hitBall());
    }

    private IEnumerator hitBall()
    {
        Vector3 hitAngle = new Vector3(xAngle, yAngle, 3);
        print("the golf ball is: " + golfBall);
        golfBall.AddForce(putter.hit(hitAngle, power));
        yield return new WaitForSeconds(5f);
    }




}

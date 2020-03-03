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



    hitBall hit;
    Stickyball stickyBall;


    public float yAngle;
    public float xAngle;

    public string currentBall;





    // Start is called before the first frame update
    void Start()
    {
        golfBall = gameObject.GetComponent<Rigidbody>();
        currentBall = "normal";
        hit = new hitBall();
        stickyBall = new Stickyball();
    }

    // Update is called once per frame
    void Update()
    {
        if (!(isMoving))
        {

            if (Input.GetKey(KeyCode.Alpha1))
            {
                currentBall = "normal";
            }
            if (Input.GetKey(KeyCode.Alpha2))
            {
                currentBall = "super";
            }
            if (Input.GetKey(KeyCode.Alpha3))
            {
                currentBall = "sticky";
            }
            if (Input.GetKey(KeyCode.Alpha4))
            {
                currentBall = "drop";
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

    

    void OnCollisionEnter(Collision collision)
    {
        if (currentBall.Equals("sticky"))
        {
            stickyBall.Stick(gameObject);
        }
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
        print("Hitting ball");
        StartCoroutine(hit.hit(currentBall, golfBall, power, gameObject.transform.rotation.x, gameObject.transform.rotation.z));
        //hit.hit(currentBall, golfBall, power, gameObject.transform.rotation.y, gameObject.transform.rotation.x);
    }






   














}
